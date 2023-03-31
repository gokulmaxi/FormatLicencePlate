namespace FormatLicencePlate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string unFormatedDMV = "2-5g-3-J"; 
          Console.WriteLine( formatDMV(unFormatedDMV,2));
        }
        static string formatDMV(string unFormatedDMV,int groupNo)
        {
            string formatedDMV =unFormatedDMV.ToUpper();
            formatedDMV =unFormatedDMV.Replace("-","");
            int index = 0;
            List<string> listGroup = new List<string>();
            char[] stringArray = formatedDMV.ToCharArray();
            Array.Reverse(stringArray);
            string reversedString = new string(stringArray);
            while (true)        {
                if (groupNo < (reversedString.Count() - index))
                {
                    string subStringGroup = formatedDMV.Substring(index, groupNo);
                    listGroup.Add(subStringGroup);
                    index = groupNo + index;
                } else
                {
                    listGroup.Add(reversedString.Substring(index));
                    break;
                }
            }
            listGroup.Reverse();
            string finalString ="";
            foreach (var item in listGroup)
            {
                finalString = item + "-" +finalString ;
            }
            return finalString;
        }
    }
}