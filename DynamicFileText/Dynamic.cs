using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;

namespace DynamicFileText
{
   public class Dynamic
    {
        public IEnumerable<dynamic> ParseFile(string fileName)
        {
            var xmList = new List<dynamic>();
            var fileStream = OpenFile(fileName);
            if (fileStream != null)
            {
                string[] txtLine = fileStream.ReadLine().Split(';').Select(s => s.Trim()).ToArray();
                //读取文件直到末尾
                while (fileStream.Peek() > 0)
                {
                    string[] dataLine = fileStream.ReadLine().Split(';');
                    dynamic dyEntity = new ExpandoObject();
                    for (int i = 0; i < txtLine.Length; i++)
                    {
                        //字典集合
                        ((IDictionary<string, object>)dyEntity).Add(txtLine[i], dataLine[i]);
                    }
                    xmList.Add(dyEntity);
                }
            }
            return xmList;
        }
        //获取文件
        private StreamReader OpenFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                return new StreamReader(File.OpenRead(fileName));
            }
            return null;
        }
    }
}
