namespace DAL_Tanach
{
    public class ClassDal
    {

        public string DataAccessRead()
        {
            string path = "C:\\Users\\נעמי\\Desktop\\לימודים\\שנה ב\\C#\\פרויקט חיפוש בתנך\\tora.txt";
            try
            {
                return File.ReadAllText(path);
            } 
            catch
            {
                throw new Exception("This file isn't exist");
            }

        }
    }  
}