using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Linq;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Transforms.Onnx;

namespace Intex2
{
    public class Program
    {
        static ITransformer GetPredictionPipeline(MLContext mlContext)
        {

            var inputColumns = new string[]
            {
                "MILEPOINT","LAT_UTM_Y","LONG_UTM_X","PEDESTRIAN_INVOLVED_True","BICYCLIST_INVOLVED_True","MOTORCYCLE_INVOLVED_True","OVERTURN_ROLLOVER_True","TEENAGE_DRIVER_INVOLVED_True","NIGHT_DARK_CONDITION_True"
            };

            var outputColumns = new string[] { "CrashSeverityID" };

            var onnxPredictionPipeline =
                    mlContext
                        .Transforms
                        .ApplyOnnxModel(
                            outputColumnNames: outputColumns,
                            inputColumnNames: inputColumns,
                            ONNX_MODEL_PATH);

            var emptyDv = mlContext.Data.LoadFromEnumerable(new OnnxInput[] { });

            return onnxPredictionPipeline.Fit(emptyDv);
        }

        static string ONNX_MODEL_PATH = "trained_model_hgboost.onnx";

        public static void Main(string[] args)
        {
            MLContext mlContext = new MLContext();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }

    public class OnnxInput
    {
        [ColumnName("MILEPOINT")]
        public float Milepoint { get; set; }

        [ColumnName("LAT_UTM_Y")]
        public float LatUtamY { get; set; }

        [ColumnName("LONG_UTM_X")]
        public float LongUtmX { get; set; }

        [ColumnName("PEDESTRIAN_INVOLVED_True")]
        public float PedestrainInvolvedTrue { get; set; }

        [ColumnName("BICYCLIST_INVOLVED_True")]
        public float BicyclistInvolvedTrue { get; set; }

        [ColumnName("MOTORCYCLE_INVOLVED_True")]
        public float MotorcycleInvolvedTrue { get; set; }

        [ColumnName("OVERTURN_ROLLOVER_True")]
        public float OverturnRolloverTrue { get; set; }

        [ColumnName("TEENAGE_DRIVER_INVOLVED_True")]
        public float TeenageDriverInvolvedTrue { get; set; }

        [ColumnName("NIGHT_DARK_CONDITION_True")]
        public float NightDarkConditionTrue { get; set; }

    }

    public class OnnxOutput
    {
        [ColumnName("variable_out1")]
        public float[] PredictedFare { get; set; }
    }
}
