﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DownloadFile
{
    public static class FileHandler
    {
        /// <summary>
        /// 文件下载目录
        /// </summary>
        private static string _directory = @"F:\临时\";

        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="url">下载地址</param>
        /// <returns>文件名称</returns>
        public static string DownloadFile(string url)
        {

                string fileName = CreateFileName(url);
                WebClient client = new WebClient();
                client.DownloadFile(url, _directory + fileName);
                return fileName;
        }

        /// <summary>
        /// 创建文件名称
        /// </summary>
        public static string CreateFileName(string url)
        {
            string fileName ;
            string fileExt = url.Substring(url.LastIndexOf(".")).Trim().ToLower();
            Random rnd = new Random();
            fileName = DateTime.Now.ToString("yyyyMMddHHmmssfff") + rnd.Next(10, 99).ToString() + fileExt;
            return fileName;
        }

        public static async Task TaksDownloadFile(string url)
        {

            Task task = Task.Run(() => Thread.Sleep(2000));
            Console.WriteLine("task Status {0}", task.Status);
            try
            {
                task.Wait();
                using (WebClient client = new WebClient())
                {
                    string fileName = CreateFileName(url);
                    client.DownloadFile(url, _directory + fileName);
                }
                Console.WriteLine("task Status {0}", task.Status);//结束
            }
            catch (AggregateException) 
            {
                Console.WriteLine("Exception in task");
            }


        }

    }
}