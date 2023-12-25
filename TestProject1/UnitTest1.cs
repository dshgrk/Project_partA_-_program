using Microsoft.VisualStudio.TestPlatform.TestHost;
using partA;

namespace partA
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CorrectAddClient()
        {
            int age = 18;
            string name = "Ім'я";

            Client client = new Client(name, age);

            Assert.IsNotNull(client);
        }

        [TestMethod]
        public void WrongAddClientName()
        {
            int age = 18;
            string name = "Ім'я";
            Client client = new Client(name, age);

            client.FirstName = "Wrong";

            Assert.AreEqual(client.FirstName, name);
        }

        [TestMethod]
        public void WrongAddClientAge()
        {
            int age = 18;
            string name = "Ім'я";
            Client client = new Client(name, age);

            client.Age = -111;

            Assert.AreEqual(client.Age, age);
        }


        [TestMethod]
        public void AddProcedureToClient()
        {
            // Arrange
            int age = 18;
            string name = "Ім'я";
            Client client = new Client(name, age);

            Procedure procedure = new Procedure(ProcedureTypes.HairCut, 50, TimeSpan.FromHours(1));
            BeautySpecialist specialist = new BeautySpecialist("Майстер", 25, procedure, 5000);
            Booking booking = new Booking(procedure, specialist);

            // Act
            client.AddProcedure(booking);

            // Assert
            Assert.AreEqual(1, client.ListOfBooking.Count);
            Assert.AreEqual(procedure, client.ListOfBooking[0].Procedure);
            Assert.AreEqual(specialist, client.ListOfBooking[0].BeautySpecialist);
        }


        [TestMethod]
        public void RemoveProcedureFromClient()
        {
            // Arrange
            int age = 18;
            string name = "Ім'я";
            Client client = new Client(name, age);

            Procedure procedure = new Procedure(ProcedureTypes.HairCut, 50, TimeSpan.FromHours(1));
            BeautySpecialist specialist = new BeautySpecialist("Майстер", 25, procedure, 5000);
            Booking booking = new Booking(procedure, specialist);
            client.AddProcedure(booking);

            // Act
            client.RemoveProcedure();

            // Assert
            Assert.AreEqual(0, client.ListOfBooking.Count);
        }


        [TestMethod]
        public void ClearProceduresForClient()
        {
            // Arrange
            int age = 18;
            string name = "Ім'я";
            Client client = new Client(name, age);

            Procedure procedure = new Procedure(ProcedureTypes.HairCut, 50, TimeSpan.FromHours(1));
            BeautySpecialist specialist = new BeautySpecialist("Майстер", 25, procedure, 5000);
            Booking booking = new Booking(procedure, specialist);
            client.AddProcedure(booking);

            // Act
            client.ClearProcedures();

            // Assert
            Assert.AreEqual(0, client.ListOfBooking.Count);
        }




        [TestMethod]
        public void CalculateMonthSalary()
        {
            // Arrange
            Procedure haircutProcedure = new Procedure(ProcedureTypes.HairCut, 80, TimeSpan.FromMinutes(90));
            BeautySpecialist specialist = new BeautySpecialist("Ліза", 30, haircutProcedure, 12000);
            Booking booking = new Booking(haircutProcedure, specialist);
            booking.BookingTime = DateTime.Now.AddDays(1);
            specialist.AddProcedure(booking);

            // Act
            decimal salary = specialist.CalculateMonthSalary(DateTime.Now.AddDays(1));

            // Assert
            decimal expectedSalary = 12000 + haircutProcedure.Price * 0.1m;
            Assert.AreEqual(expectedSalary, salary);
        }



        [TestMethod]
        public void CorrectAddBooking()
        {
            // Arrange
            Procedure procedure = new Procedure(ProcedureTypes.Pedicure, 45, TimeSpan.FromMinutes(75));
            BeautySpecialist specialist = new BeautySpecialist("Майстер", 30, procedure, 6000);
            Client client = new Client("Ім'я", 25);
            DateTime bookingTime = DateTime.Now.AddHours(2);

            // Act
            Booking booking = new Booking(procedure, specialist);
            booking.Client = client;
            booking.BookingTime = bookingTime;

            // Assert
            Assert.IsNotNull(booking);
            Assert.AreEqual(procedure, booking.Procedure);
            Assert.AreEqual(specialist, booking.BeautySpecialist);
            Assert.AreEqual(client, booking.Client);
            Assert.AreEqual(bookingTime, booking.BookingTime);
        }


        [TestMethod]
        public void InvalidBeautySpecialistName()
        {
            BeautySpecialist beautySpec = new BeautySpecialist();

            beautySpec.FirstName = "Wrong";

            Assert.IsNull(beautySpec.FirstName);
        }

        [TestMethod]
        public void InvalidBeautySpecialistAge()
        {
            BeautySpecialist beautySpec = new BeautySpecialist();

            beautySpec.Age = -1;

            Assert.AreEqual(beautySpec.Age, 0);
        }


        [TestMethod]
        public void InvalidProcedurePrice()
        {
            Procedure procedure = new Procedure();

            procedure.Price = -1;

            Assert.AreEqual(procedure.Price, 0);
        }


    }
}