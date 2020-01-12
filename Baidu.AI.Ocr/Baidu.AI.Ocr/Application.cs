
namespace Baidu.AI.Ocr
{
    /// <summary>
    /// The Application class represents the starting point for the backend work using your chosen SDK.
    /// </summary>
    public class Application
    {
        #region Constructors

        // Creates a new, blank Application
        public Application() { }

        public Application(string apiKey, string secretKey)
        {
            BaiduOcrClient = new Aip.Ocr.Ocr(apiKey, secretKey);
        }

        #endregion

        #region Public Properties

        public Baidu.Aip.Ocr.Ocr BaiduOcrClient { get; }

        #endregion
    }
}
