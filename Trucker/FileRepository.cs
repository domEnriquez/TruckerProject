using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Trucker
{
    public abstract class FileRepository
    {
        protected string storageFile;

        public Entity Get(int id)
        {
            if (!File.Exists(storageFile))
                throw new NoExistingStorageFileExcepition("There is no existing storage file");

            using (StreamReader file = new StreamReader(storageFile))
            {
                string line = string.Empty;

                while ((line = file.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');

                    if (fields[0] == id.ToString())
                        return MakeEntity(fields);
                }
            }

            return null;
        }

        public IEnumerable<Entity> GetAll()
        {
            if (!File.Exists(storageFile))
                throw new NoExistingStorageFileExcepition("There is no existing storage file");

            List<Entity> entities = new List<Entity>();

            using (StreamReader file = new StreamReader(storageFile))
            {
                string line = string.Empty;

                while ((line = file.ReadLine()) != null)
                    entities.Add(MakeEntity(line.Split(',')));
            }

            return entities;
        }

        public void Add(Entity entity)
        {
            if (entity == null)
                throw new ArgumentNullException("Trip should not be null");

            if (!File.Exists(storageFile))
                throw new NoExistingStorageFileExcepition("There is no existing storage file");

            incrementId(entity);

            using (StreamWriter file =
                new StreamWriter(storageFile, true))
            {
                file.WriteLine(entity.ConvertToCsv());
            }
        }

        private void incrementId(Entity entity)
        {
            IEnumerable<string> fileLines = File.ReadLines(storageFile);

            if (fileLines.Any())
            {
                string lastLine = fileLines.Last();

                if (!string.IsNullOrEmpty(lastLine))
                    entity.Id = Convert.ToInt32(lastLine.Split(',')[0]) + 1;
            }
        }

        public void Delete(int id)
        {
            if (Get(id) == null)
                throw new NoExistingEntityExcepition();

            string tempFile = Path.GetTempFileName();

            using (var sr = new StreamReader(storageFile))
            using (var sw = new StreamWriter(tempFile))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                    if (line.Split(',')[0] != id.ToString())
                        sw.WriteLine(line);
            }

            File.Delete(storageFile);
            File.Move(tempFile, storageFile);
        }

        protected abstract Entity MakeEntity(string[] fields);
        public void SetStorageFile(string path)
        {
            storageFile = path;
        }

        public class NoExistingStorageFileExcepition : ApplicationException
        {
            public NoExistingStorageFileExcepition()
            {

            }

            public NoExistingStorageFileExcepition(string message)
                : base(message)
            {

            }
        }

        public class NoExistingEntityExcepition : ApplicationException
        {
            public NoExistingEntityExcepition()
            {

            }

            public NoExistingEntityExcepition(string message)
                : base(message)
            {

            }
        }
    }
}
