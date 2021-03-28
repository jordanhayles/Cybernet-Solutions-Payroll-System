//INTRODUCTION TO PROGRAMMING 
//COURSE WORK GROUP PRESENTATION
//DUE DATE:NOVEMBER 25,2016
//Jordan Hayles 20161108
//Javier Bailey
//Aquila Thomas
//Ramona Rowe
using System;
class Payroll_system
{

    public static void Welcome()
    {//  Procedure used for the introduction of the Company's Payroll System
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(" Welcome To Cybernet Solutions Ltd Payroll System");
        Console.WriteLine("");                                     //Console.WriteLine("") means to space out
        Console.WriteLine("");
        Console.WriteLine("<<Press any key to continue>>");
        Console.ReadKey();
        Console.Clear();


    }

    public struct payroll //Structure name 'payroll' stores all variables
    {

        private int _menu1, _employid, _level, _hrs, _ratings, _menu;
        private double _nis, _nht, _edtax, _incometax, _grosspay, _netpay, _totaldeduct, _totalpay, _bonus, _per4, _per3, _per2, _per1, _hourlyrate, _monthlyovertimehrs, _overpay, _overtimepay, _salary, _bonusp;
        private char type, answer;
        private string _employname;

        public int menu1
        {

            get { return this._menu1; }
            set { this._menu1 = value; }
        }
        public int employid
        {
            get { return this._employid; }
            set { this._employid = value; }
        }
        public int hrs
        {
            get { return this._hrs; }
            set { this._hrs = value; }
        }
        public int level
        {
            get { return this._level; }
            set { this._level = value; }
        }

        public string employname
        {
            get { return this._employname; }
            set { this._employname = value; }
        }

        public char _answer
        {

            get { return this._answer; }
            set { this._answer = value; }
        }
        public char _type
        {

            get { return this._type; }
            set { this._type = value; }
        }
        public double nis
        {
            get { return this._nis; }

            set { this._nis = value; }
        }

        public double nht
        {

            get { return this._nht; }
            set { this._nht = value; }
        }

        public double edtax
        {

            get { return this._edtax; }
            set { this._edtax = value; }
        }

        public double incometax
        {

            get { return this._incometax; }
            set { this._incometax = value; }
        }
        public double grosspay
        {

            get { return this._grosspay; }
            set { this._grosspay = value; }
        }
        public double netpay
        {

            get { return this._netpay; }
            set { this._netpay = value; }
        }
        public double totaldeduct
        {

            get { return this._totaldeduct; }
            set { this._totaldeduct = value; }
        }
        public double totalpay
        {

            get { return this._totalpay; }
            set { this._totalpay = value; }
        }
        public double bonus
        {

            get { return this._bonus; }
            set { this._bonus = value; }
        }
        public double per4
        {

            get { return this._per4; }
            set { this._per4 = value; }
        }
        public double per3
        {

            get { return this._per3; }
            set { this._per3 = value; }
        }
        public double per2
        {

            get { return this._per2; }
            set { this._per2 = value; }
        }
        public double per1
        {

            get { return this._per1; }
            set { this._per1 = value; }
        }
        public double salary
        {

            get { return this._salary; }
            set { this._salary = value; }
        }
        public double hourlyrate
        {

            get { return this._hourlyrate; }
            set { this._hourlyrate = value; }
        }
        public double monthlyovertimehrs
        {

            get { return this._monthlyovertimehrs; }
            set { this._monthlyovertimehrs = value; }
        }
        public double overpay
        {

            get { return this._overpay; }
            set { this._overpay = value; }
        }
        public double overtimepay
        {

            get { return this._overtimepay; }
            set { this._overtimepay = value; }
        }
        public double bonusp
        {

            get { return this._bonusp; }
            set { this._bonusp = value; }
        }
        public int menu
        {

            get { return this._menu; }
            set { this._menu = value; }
        }
        public int ratings
        {

            get { return this._ratings; }
            set { this._ratings = value; }
        }





        static void Main()
        {
            Welcome(); //Procedure call


            payroll[] pay = new payroll[6];//Structured array with its arrayname as 'pay'. 
            for (int x = 1; x <= 6; x++) //for loop is used to repeat the same line based on how many numbers are in the '[ ]'
            {                         //When using readline. Variable must have  pay[x].(variable name)=.......
                do
                    do
                        do
                            do
                            //if you make a mistake the while loop allows you to Re-enter value
                            {
                                Console.WriteLine("................................................................................");
                                Console.WriteLine("....................................MENU........................................");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("Enter 1 to calculate 'Payroll'");
                                Console.WriteLine("");
                                Console.WriteLine("Enter 2 to generate 'Payslips'");
                                Console.WriteLine("");
                                Console.WriteLine("Enter 3 to generate 'Monthly Employee Monthly Report'");
                                Console.WriteLine("");
                                Console.WriteLine("Enter 4 to generate 'Houlry Employee Monthly Report'");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("                                                         Enter 0 to 'Exit'");

                                pay[x]._menu = int.Parse(Console.ReadLine());
                                Console.Clear();



                                if (pay[x].menu == 3)
                                {

                                    Console.WriteLine("Please calculate payroll first.");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                if (pay[x].menu1 == 4)
                                {

                                    Console.WriteLine("Please calculate payroll first.");
                                    Console.ReadKey();
                                    Console.Clear();

                                }
                                    if (pay[x].menu == 0)
                                { return; }
                                else { }
                            }
                            while (pay[x].menu == 2);
                        while (pay[x].menu == 3);
                    while (pay[x].menu == 0);
                while (pay[x].menu1 == 4);


                if (pay[x].menu == 1)
                {
                    Console.WriteLine("Employee #" + x);
                    Console.WriteLine("Please enter Employee Name");
                    pay[x]._employname = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Enter Identification Number(ID)");
                    pay[x].employid = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Enter m  for Monthly Employee or h for Hourly Employee");
                    pay[x].type = Convert.ToChar(Console.ReadLine());
                    Console.Clear();


                    if (pay[x].type == 'h')
                    {
                        do //do while is a post test
                        {
                            Console.Clear();
                            Console.WriteLine(" Note:Working hours should not be less than 160 hours ");
                            Console.WriteLine("");
                            Console.WriteLine("Please enter hours");
                            pay[x].hrs = Convert.ToInt16(Console.ReadLine());

                            if (pay[x].hrs > 160)
                            {
                                Console.Clear();
                                Console.WriteLine("Hours should be no less than 160 please enter again");
                                Console.ReadKey();
                            }

                            pay[x].hourlyrate = 350.00;
                            pay[x].salary = pay[x].hourlyrate * pay[x].hrs;


                        }
                        while (pay[x].hrs > 160);
                    }
                    else if (pay[x].type == 'm')
                    {
                        Console.WriteLine("Please enter Salary level: 1,2,3,4 or 5");
                        pay[x].level = Convert.ToInt16(Console.ReadLine());
                        Console.Clear();
                    }
                    if (pay[x].level == 1)
                    {
                        pay[x].salary = 60000;
                        //[0:c] represents currency$
                    }
                    else if (pay[x].level == 2)

                    {
                        pay[x].salary = 75000;

                    }

                    else if (pay[x].level == 3)
                    {
                        pay[x].salary = 90000;
                        Console.WriteLine("Salary is {0:c}", pay[x].salary);
                    }
                    else if (pay[x].level == 4)
                    {
                        pay[x].salary = 120000;
                        Console.WriteLine("Salary is {0:c}", pay[x].salary);
                    }
                    else if (pay[x].level == 5)
                    {
                        pay[x].salary = 150000;
                        Console.WriteLine("Salary is {0:c}", pay[x].salary);
                    }

                    Console.Clear();

                    Console.WriteLine("Do you work overtime? n(no) or y(yes) ");
                    pay[x].answer = Convert.ToChar(Console.ReadLine());
                    Console.Clear();

                    if (pay[x].answer == 'y')
                    {
                        do
                        {
                            //Overtime pay rate (overpay) is 250.00 per  1 to 5 hrs for the week
                            Console.WriteLine("Overtime pay rate (overpay) is $250.00 per  1 to 5 hrs for the week");
                            Console.WriteLine("");
                            Console.WriteLine("Hours should no less than 25");
                            Console.WriteLine("");
                            Console.WriteLine("Pleae Enter over time hours for the entire month");
                            pay[x].monthlyovertimehrs = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();

                            if (pay[x].monthlyovertimehrs > 25)
                            {

                                Console.WriteLine("Hours must be no less than 25. Please re-enter again");
                                Console.ReadKey();
                                Console.Clear();
                            }

                            pay[x].overpay = 250.00;
                            pay[x].overtimepay = pay[x].overpay * pay[x].monthlyovertimehrs;
                            pay[x].salary = pay[x].salary + pay[x].overtimepay;

                        }
                        while (pay[x].monthlyovertimehrs > 25);
                    }


                    else if (pay[x].answer == 'n')
                    {
                        pay[x].salary = pay[x].salary;

                    }
                    //per1,per2,per3,per4 represent percentages%
                    pay[x].per1 = 0.025;
                    pay[x].nis = pay[x].per1 * pay[x].salary;

                    if (pay[x].salary > 100000)
                    {
                        pay[x].per2 = 0.15;
                        pay[x].incometax = pay[x].per2 * pay[x].salary;

                    }
                    else if (pay[x].salary < 100000)
                    {
                        pay[x].per2 = 0.10;
                        pay[x].incometax = pay[x].per2 * pay[x].salary;

                    }
                    pay[x].per3 = 0.0225;
                    pay[x].edtax = pay[x].per3 * pay[x].salary;
                    pay[x].per4 = 0.02;
                    pay[x].nht = pay[x].per4 * pay[x].salary;
                    pay[x].totaldeduct = pay[x].nht + pay[x].edtax + pay[x].incometax + pay[x].nis;

                    pay[x].grosspay = pay[x].salary;
                    pay[x].netpay = pay[x].grosspay - pay[x].totaldeduct;
                    pay[x].totalpay = pay[x].netpay;


                    Console.WriteLine("Please Enter Performance Rating 1,2,3,4 or 5");
                    pay[x].ratings = Convert.ToInt16(Console.ReadLine());

                    switch (pay[x].ratings)  //A CASE was used for perfomance rating and bonus
                    {
                        case 1:
                            pay[x].bonusp = 0.25;
                            pay[x].bonus = pay[x].totalpay * pay[x].bonusp;
                            pay[x].totalpay = pay[x].totalpay + pay[x].bonus;
                            break;
                        case 2:
                            pay[x].bonusp = 0.015;
                            pay[x].bonus = pay[x].totalpay * pay[x].bonusp;
                            pay[x].totalpay = pay[x].totalpay + pay[x].bonus;
                            break;
                        case 3:
                            pay[x].bonusp = 0.10;
                            pay[x].bonus = pay[x].totalpay * pay[x].bonusp;
                            pay[x].totalpay = pay[x].totalpay + pay[x].bonus;
                            break;
                        case 4:
                            pay[x].bonusp = 0.05;
                            pay[x].bonus = pay[x].totalpay * pay[x].bonusp;
                            pay[x].totalpay = pay[x].totalpay + pay[x].bonus;
                            break;
                        default:
                            Console.WriteLine("No Bonus!");
                            break;
                    }



                    do              //the while loop is a post test
                        do
                            do
                                do
                            {
                                Console.Clear();
                                    Console.WriteLine("................................................................................");
                                    Console.WriteLine("....................................MENU........................................");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("Enter 1 to calculate 'Payroll'");
                                    Console.WriteLine("");
                                    Console.WriteLine("Enter 2 to generate 'Payslips'");
                                    Console.WriteLine("");
                                    Console.WriteLine("Enter 3 to generate 'Monthly Employee Monthly Report'");
                                    Console.WriteLine("");
                                    Console.WriteLine("Enter 4 to generate 'Houlry Employee Monthly Report'");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("                                                         Enter 0 to 'Exit'");

                                    pay[x]._menu1 = int.Parse(Console.ReadLine());
                                Console.Clear();


                                foreach (payroll r in pay) //display all employee pay slips
                                {                          //foreach is used with a new variable 'i'
                                    if (pay[x].menu1 == 2)
                                    {

                                        Console.WriteLine(".........PAYSLIP.......");   //Print payslip for each employee
                                        Console.WriteLine("");
                                        Console.WriteLine("Employee Name:" + " " + r.employname);
                                        Console.WriteLine("");
                                        Console.WriteLine("Employee ID:" + " " + r.employid);
                                        Console.WriteLine("");
                                        Console.WriteLine("Gross Pay: {0:c}", r.grosspay);//[0:c] represents currency$
                                        Console.WriteLine("");
                                        Console.WriteLine("Net Pay:{0:c}", r.netpay);
                                        Console.WriteLine("");
                                        Console.WriteLine("ED Tax: {0:c}", r.edtax);
                                        Console.WriteLine("");
                                        Console.WriteLine("Income Tax: {0:c}", r.incometax);
                                        Console.WriteLine("");
                                        Console.WriteLine("NIS:{0:c}", r.nis);
                                        Console.WriteLine("");
                                        Console.WriteLine("NHT: {0:c}", r.nht);
                                        Console.WriteLine("");
                                        Console.WriteLine("Total Deduction: {0:c}", r.totaldeduct);
                                        Console.WriteLine("");
                                        Console.WriteLine("Overtime Pay: {0:c}", r.overtimepay);
                                        Console.WriteLine("");
                                        Console.WriteLine("Bonus: {0:c}", r.bonus);
                                        Console.WriteLine("");
                                        Console.WriteLine("Total Pay: {0:c}", r.totalpay);
                                        Console.WriteLine("");
                                        Console.ReadKey();

                                    }
                                }

                                if (pay[x].menu1 == 3)
                                {

                                    Console.Clear();

                                    double totalgrosspay = 0;
                                    double totalnetpay = 0;
                                    double totalovertimepay = 0;
                                    double totalbonus = 0;

                                    foreach (payroll i in pay)

                                    {

                                        if (i.type == 'm')   //type means the type of employee
                                        {
                                            Console.WriteLine("....Monthly Employee Monthly Report....");
                                            Console.WriteLine("");
                                            totalgrosspay += i.grosspay;
                                            Console.WriteLine("Total Gross Pay: {0:c}", totalgrosspay);
                                            Console.WriteLine("");
                                            totalnetpay += i.netpay;
                                            Console.WriteLine("Total Net Pay: {0:c}", totalnetpay);
                                            Console.WriteLine("");
                                            totalovertimepay += i.overtimepay;
                                            Console.WriteLine("Total Overtime Pay: {0:C}", totalovertimepay);
                                            Console.WriteLine("");
                                            totalbonus += i.bonus;
                                            Console.WriteLine("Total Bonus: {0:c}", totalbonus);
                                            Console.ReadKey();
                                            Console.WriteLine("");
                                            Console.Clear();
                                        }
                                    }
                                }
                                if (pay[x].menu1 == 4)
                                {
                                    foreach (payroll e in pay)

                                    {
                                        double totalgrosspay1 = 0;
                                        double totalnetpay1 = 0;
                                        double totalovertimepay1 = 0;
                                        double totalbonus1 = 0;

                                        if (e.type == 'h')
                                        {


                                            Console.WriteLine("....Hourly Employee Monthly Report....");
                                            Console.WriteLine("");
                                            totalgrosspay1 += e.grosspay;
                                            Console.WriteLine("Total Gross Pay: {0:c}", totalgrosspay1);
                                            Console.WriteLine("");
                                            totalnetpay1 += e.netpay;
                                            Console.WriteLine("Total Net Pay: {0:c}", totalnetpay1);
                                            Console.WriteLine("");
                                            totalovertimepay1 += e.overtimepay;
                                            Console.WriteLine("Total Overtime Pay: {0:C}", totalovertimepay1);
                                            Console.WriteLine("");
                                            totalbonus1 += e.bonus;
                                            Console.WriteLine("Total Bonus: {0:c}", totalbonus1);
                                            Console.ReadKey();
                                            Console.WriteLine("");
                                                Console.Clear();


                                        }
                                    }
                                }


                                else if (pay[x].menu1 == 0)
                                { return; }



                            }
                            while (pay[x].menu1 == 2);
                        while (pay[x].menu1 == 3);
                    while (pay[x].menu1 == 0);
                    while (pay[x].menu1 == 4) ;

                }

            }

        }

    }

}









