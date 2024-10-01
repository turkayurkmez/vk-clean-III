using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{

    /// <summary>
    /// Excel dosyasındaki verileri alıp, pdf formatında bir rapora dönüştürecek nesne.
    /// </summary>
    public class ReportGenerator
    {
        //Amaç: Verilen bir excel dosyasındaki verileri alıp, pdf formatında bir rapora dönüştürecek nesne.

        private string excelFilePath;
        public ReportGenerator(string excelFilePath)
        {
            //1. parametre dolu mu boş mu?
            //2. parametrede gerçekten de bir dosya var mı?
            //3. Excel dosyası, doğru formatta mı?

            //if (string.IsNullOrEmpty(excelFilePath))
            //{
            //    throw new ArgumentNullException("Excel dosyasının adresi belirtilmeli!");
            //}
            //Syntax'daki değişikliği veya yeni tekniğini koda yansıtın:
            ArgumentNullException.ThrowIfNullOrEmpty(excelFilePath);
            checkFileIsValid(excelFilePath);

            this.excelFilePath = excelFilePath;

            //if (isValidFile(excelFilePath))
            //{
            //    throw new ArgumentException("Excel dosyası yok veya format hatalı");
            //}


        }

        bool isFileExists(string path) => File.Exists(path);

        private bool isValidFormat(string excelFilePath) => true;

        void checkFileIsValid(string path)
        {
            if (!isFileExists(path))
            {
                throw new FileNotFoundException(path);
            }

            if (!isValidFormat(path))
            {
                throw new ArgumentException($"{path} adresi uygun formatta değil");
            }
        }

        /// <summary>
        /// Bu metod, istenen raporu oluşturmaya başlar.
        /// </summary>
        /// <param name="title">Rapor başlığı...</param>
        /// <param name="isColor">Renkli baskı mı? </param>
        /// <param name="isIncludeGraph"></param>
        /// <param name="designers"></param>
        /// <param name="detailsData"></param>
        public void CreateReport(ReportOption option)
        {

        }
    }
}
