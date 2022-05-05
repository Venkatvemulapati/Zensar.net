using System;

namespace CodeBasedQuestion
{
    internal class TrainTicket
    {
        class Passenger
        {
            public String Name { get; set; }
            public int Age { get; set; }
            Ticket Ticket { get; set; }
            public String Date { get; set;}


            public Passenger(string name, int age ,string date)
            {
                Name = name;
                Age = age;
                DateOfJourney = date;
                Ticket = new Ticket();

            }
            public void TicketBooking(int tickets)
            {
                Ticket.Tickets = tickets;
                Console.WriteLine("Ticket booked successfully");
            }
        }
        class Ticket
        {
            public int Tickets;
            public int tickets
            {
                get => tickets;
                set
                {



                    if (value > 5)

                        throw new Exception("One time you can book only less than 5 tickets");


                    else

                        tickets = value;
                }
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Date of journey");
            String Date = Console.ReadLine();
            Passenger passenger = new Passenger("sai", 24,Date);
            Console.WriteLine("Enter the number of tickets want to book");
            passenger.TicketBooking(int.Parse(Console.ReadLine()));
            Console.ReadKey();
        }



    }
}

