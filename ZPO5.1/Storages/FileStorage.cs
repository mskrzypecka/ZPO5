using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO5;
using ZPO5.Interfaces;

namespace ZPO5
{
    public class FileStorage : IStore, IFileLocator
    {
        ICacheStore cache;
        Logger logger;
        MessageStorage messages;

        public DirectoryInfo WorkingDirectory { get; set; }

        public FileStorage(DirectoryInfo workingDirectory)
        {
            cache = messages.Cache;
            logger = messages.Logger;
            WorkingDirectory = workingDirectory;

            if (workingDirectory == null)
                throw new ArgumentNullException("workingDirectory is null");

            if (!workingDirectory.Exists)
                throw new ArgumentNullException("workingDirectory does not exists");
        }

        public virtual bool Save(string id, string message)
        {
            logger.INFO($"INFO: Saving message {id}.");

            FileInfo file = this.GetFileInfo(id);
            File.WriteAllText(file.FullName, message);

            cache.AddOrUpdate(id, message);
            logger.INFO($"Saved messagee {id}.");

            return true;
        }

        public virtual string Read(string id)
        {
            logger.DEBUG($"Readline message {id}.");
            var file = this.GetFileInfo(id);

            if (!file.Exists)
            {
                logger.DEBUG($"No message {id} found.");
                return "";
            }

            cache.AddOrUpdate(id, File.ReadAllText(file.FullName));
            logger.DEBUG($"Returning message {id}.");
            return cache.Get(id);
        }

        public virtual FileInfo GetFileInfo(string name) 
            => new FileInfo(WorkingDirectory.FullName + "/" + name + ".txt");
    }
}
