// See https://aka.ms/new-console-template for more information
Console.WriteLine("***Water bill calculation program***");

// khai bao ham xu ly chuong trinh 
void CalculationWaterBill()
{
    Console.WriteLine("Enter the Customer Name : ");
    string customer = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Please select your customer type");
    Console.WriteLine("Enter number 1 if you are a home customer type, then press enter");
    Console.WriteLine("Enter number 2 if you are a customer with administrative agency, then press enter");
    Console.WriteLine("Enter number 2 if you are a production units, then press enter");
    Console.WriteLine("Enter number 2 if you are a bussiness services, then press enter");
    int typeCustomer = Convert.ToInt32(Console.ReadLine());
    if (typeCustomer == 1)
    {
        Console.WriteLine("Enter the number of members in the family");
        int numberMember = Convert.ToInt32(Console.ReadLine());
        if (numberMember >= 1)
        {
            Console.WriteLine("Please enter last month water number");
            int waterNumberLastMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter this month water number");
            int waterNumberCurrentMOnth = Convert.ToInt32(Console.ReadLine());
            if (waterNumberCurrentMOnth >= waterNumberLastMonth)
            {
                int waterNumber = waterNumberCurrentMOnth - waterNumberLastMonth;
                double waterNumberPeople = waterNumber / numberMember;
                double money = 0;
                if (waterNumberPeople > 0 && waterNumber <= 10)
                {
                    money = waterNumber * 5973 * 1.1;
                }
                else if (waterNumberPeople > 10 && waterNumberPeople <= 20)
                {
                    money = waterNumber * 7051 * 1.1;
                }
                else if (waterNumberPeople > 20 && waterNumberPeople <= 30)
                {
                    money = waterNumber * 8699 * 1.1;
                }
                else
                {
                    money = waterNumber * 15929 * 1.1;
                }
                Console.WriteLine("Your family's water bill is  : {0}", money);
            }
        }
        else
        {
            Console.WriteLine("You are not a family customer");
        }
    }
    else if (typeCustomer == 2)
    {
        // khach hang co quan hanh chinh cong
        Console.WriteLine("Please enter last month water number");
        int waterLastMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter this month water number");
        int waterCurrentMonth = Convert.ToInt32(Console.ReadLine());
        if (waterLastMonth <= waterCurrentMonth)
        {
            double m = (waterCurrentMonth - waterLastMonth) * 9955 * 1.1;
            Console.WriteLine("Water bill of your administrative agency is {0}", m);
        }
        else
        {
            Console.WriteLine("This month's water number is no greater than the previous month's water number");
        }
    }
    else if (typeCustomer == 3)
    {
        // khach hang don vi san xuat
        Console.WriteLine("Please enter last month water number");
        int waterLastMonth1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter this month water number");
        int waterCurrentMonth1 = Convert.ToInt32(Console.ReadLine());
        if (waterLastMonth1 >= waterCurrentMonth1)
        {
            double w = (waterCurrentMonth1 - waterLastMonth1) * 11615 * 1.1;
            Console.WriteLine("Water bill of your production units is {0}", w);
        }
        else
        {
            Console.WriteLine("This month's water number is no greater than the previous month's water number");
        }
    }
    else if (typeCustomer == 4)
    {
        // khach hang dich vu kinh doanh
        Console.WriteLine("Please enter last month water number");
        int waterLastMonth2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter this month water number");
        int waterCurrentMonth2 = Convert.ToInt32(Console.ReadLine());
        if (waterLastMonth2 >= waterCurrentMonth2)
        {
            double e = (waterCurrentMonth2 - waterLastMonth2) * 22068 * 1.1;
            Console.WriteLine("Water bill of your bussiness services is {0}", e);
        }
        else
        {
            Console.WriteLine("This month's water number is no greater than the previous month's water number");
        }
    }
    else
    {
        Console.WriteLine("Please enter the customer type");y
    }
}
    // chay chuong trinh 
    CalculationWaterBill();