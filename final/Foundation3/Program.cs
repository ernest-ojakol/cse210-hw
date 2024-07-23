using System;

class Program
{
    static void Main(string[] args)
    {
        Address address=new Address("Mutungo Zone 4, Mutungo Ring Road, 10","Kampala","Central","Uganda");
        LecturesEvent lectureEvent=new LecturesEvent("Daily Devotion","Acts of Daily Devotion","23/JULY/2024","1700Hrs",address,"Rita Kyomugisha","150 Participants");

        address=new Address("Source of the Nile Gardens","Jinja","Kiira","Uganda");
        OutdoorEvent outdoorEvent=new OutdoorEvent("Nyege Nyege Music Festival","Nyege Nyege On The Nile","27/JULY/2024 - 30/JULY/2024","3 Days",address,"Light Rain");

        address=new Address("Source of the Nile Hotel","Jinja","Kiira","Uganda");
        ReceptionEvent receptionEvent=new ReceptionEvent("Ernest And Rita's Wedding Reception","Wedding Reception for Ernest and Rita","19/Feb/2024","1400Hrs",address,"ooquirrino@gmail.com");

        Console.WriteLine($"\n\n{lectureEvent.GetShortDescription()}");
        Console.WriteLine($"{lectureEvent.GetFullDetails()}\n\n");

        Console.WriteLine($"{outdoorEvent.GetShortDescription()}");
        Console.WriteLine($"{outdoorEvent.GetFullDetails()}\n\n");

        Console.WriteLine($"{receptionEvent.GetShortDescription()}");
        Console.WriteLine($"{receptionEvent.GetFullDetails()}\n\n");

 
    }
}