namespace _03.PhoneShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();

            string cmd;

            while ((cmd = Console.ReadLine()) != "End")
            {
                string[] cmdArr = cmd.Split(" - ");
                string phone = cmdArr[1];

                if (cmdArr[0] == "Add")
                {
                    if (!list.Contains(phone))
                    {
                        list.Add(phone);
                    }
                }
                else if (cmdArr[0] == "Remove")
                {
                    if (list.Contains(phone))
                    {
                        list.Remove(phone);
                    }
                }
                else if (cmdArr[0] == "Bonus phone")
                {
                    string[] bonusPhoneSplit = phone.Split(':');
                    string oldPhone = bonusPhoneSplit[0];
                    string newPhone = bonusPhoneSplit[1];
                    if (list.Contains(oldPhone) && (!list.Contains(newPhone)))
                    {
                        int indexToInsertTheNewPhone = list.IndexOf(oldPhone) + 1;

                        if (indexToInsertTheNewPhone < list.Count)
                        {
                            list.Insert(indexToInsertTheNewPhone, newPhone);
                        }
                        else
                        {
                            list.Add(newPhone);
                        }
                        
                    }

                }
                else if (cmdArr[0] == "Last")
                {
                    if(list.Contains(phone))
                    {
                        list.Remove(phone);
                        list.Add(phone);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}