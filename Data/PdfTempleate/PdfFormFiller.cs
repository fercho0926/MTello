
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using System.IO;

namespace Data.PdfTempleate
{
    public  class PdfFormFiller
    {


        public void FillPdfForm(string templatePath, string outputPath, Dictionary<string, string> fieldValues)
        {


            Console.WriteLine("Current Directory: " + Directory.GetCurrentDirectory());


            using (var reader = new PdfReader(templatePath))
            using (var fileStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
            using (var stamper = new PdfStamper(reader, fileStream))
            {
                var form = stamper.AcroFields;
                foreach (var field in fieldValues)
                {
                    form.SetField(field.Key, field.Value);
                }
                stamper.FormFlattening = true; // Flatten the form to make the content uneditable
            }
        }

        //// Usage
        //var fieldValues = new Dictionary<string, string>
        //{
        //    { "fieldName1", "Value1" },
        //    { "fieldName2", "Value2" }
        //};
        //PdfFormFiller("template.pdf", "output.pdf", fieldValues);




    }
}
