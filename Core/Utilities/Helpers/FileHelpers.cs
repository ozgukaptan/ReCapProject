using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;


namespace Core.Utilities.Helpers
{
    public class FileHelpers
    {
        public static string Add(IFormFile file)
        {
            var sourcePath = Path.GetTempFileName();
            if (file.Length > 0)
            {
                using (var stream = new FileStream(sourcePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            var result = newPath(file);
            File.Move(sourcePath, result);
            
            return result;
        }

        public static IResult Delete (string path)
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception exeption)
            {

                return new ErrorResult(exeption.Message);
            }
            return new SuccessResult();
        }

        public static string Update(string sourcePath,IFormFile file)
        {
            var result = newPath(file);
            if(sourcePath.Length > 0 )
            {
                using (var stream = new FileStream(result,FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            File.Delete(sourcePath);
            return result;
        }



        public static string newPath(IFormFile file)
        {
            FileInfo fileInfo = new FileInfo(file.FileName);
            string fileExtension = fileInfo.Extension;

            string path = Environment.CurrentDirectory + @"\wwwroot\uploads";
            var newPath = Guid.NewGuid().ToString() + "_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + fileExtension;

            string result = $@"{ path}\{newPath}";
            return result;
        }
    }
}








