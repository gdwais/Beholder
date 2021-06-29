using Microsoft.ML.Data;

namespace Beholder.Cli.Data
{
    public class Prediction
    {
        [ColumnName("grid")]
        public float[] PredictedLabels;
    }
    
}