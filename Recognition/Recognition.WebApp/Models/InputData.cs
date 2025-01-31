using Microsoft.ML;
using Microsoft.ML.Data


namespace Recognition.WebApp.Models
{
    public class InputData
    {
        [ImageInput]
        public Image<Bgr, byte> Image { get; set; }
    }
}