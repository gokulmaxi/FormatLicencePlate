namespace FormatLicencePlate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string unFormatedDMV = "2-5sd-fg-3-J";
            Console.WriteLine(formatDMV(unFormatedDMV, 4));

            static string formatDMV(string unFormatedDMV, int groupNo)
            {

                List<string> listGroup = new List<string>();
                // convert string to upper and reverse the string
                string upperCaseDMV = unFormatedDMV.ToUpper();
                string formatedDMV = upperCaseDMV.Replace("-", "");
                int index = formatedDMV.Count();
                while (true)
                {
                    if (groupNo <  index)
                    {
                        index = index - groupNo;
                        string subStringGroup = formatedDMV.Substring(index, groupNo);
                        listGroup.Add(subStringGroup);
                       // index = groupNo + index;
                    }
                    else
                    {
                        listGroup.Add(formatedDMV.Substring(0,index));
                        break;
                    }
                }
                listGroup.Reverse();
                string finalDMV = string.Join("-", listGroup.ToArray());
                return finalDMV;
            }
        }
    }
}