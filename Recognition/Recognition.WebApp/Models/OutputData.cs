using Microsoft.ML.Data;

namespace Recognition.WebApp.Models
{
    public class OutputData
    {
        [ColumnName("PredictedLabel")]
        public string Prediction { get; set; }
    }
}