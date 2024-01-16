using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevDelBo
{
    internal class Deletador
    {

        public static void Deleter(string path)
        {
          
            var stringPath = path;
            var pathsObj = Directory.GetDirectories(stringPath, "obj", SearchOption.AllDirectories);
            try
            {
                foreach (var dir in pathsObj)
                {
                    Directory.Delete(dir, true);
                }
            }catch(Exception ex) {
                throw ex;
            }

            var pathsBin = Directory.GetDirectories(stringPath, "bin", SearchOption.AllDirectories);
            pathsBin = pathsBin.Where(x => !x.Contains("node")).ToArray();
            try
            {
                foreach (var dir in pathsBin)
                {
                    Directory.Delete(dir, true);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
    }
}
