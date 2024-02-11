//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");




//Hometask- Stack, heap, break



//1) n - ededinin faktorialini hesablayin.



//int n = 4;
//int result = 1;

//for (int i = 1; i <= n; i++)
//{
//    result *= i;


//}

//Console.WriteLine(result);



//2) Verilmis arrayin icerisinde cut ededlerin ceminin kvadratini hesablayin.


//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 2, 3, 24, };
//int result = 0; 

//for ( int i = 0; i < arr.Length; i++ )
//{
//    if (arr[i] % 2 == 0)
//    {
//        result += arr[i];
//    }    

//}
// int kvadrat = result * result ;

//Console.WriteLine(kvadrat);






//3) n ededi gelir. n - ededinin 2-ni hansisa quvvete yukseltdikde alinan edede beraber olub-olmadigini tapin. Meselen : n ededi 4,8,16 ve s. gelirse yazilsin ki, 2-nin quvettidir. Eks halda quvveti deil yazilsin.


//int n = 4;
//int result = 1;


//while ( result < n )

//{
//    result *= 2;

//}

//if ( result == n)
//{
//    Console.WriteLine("2-nin quvvetidir");
//}
//else
//{
//    Console.WriteLine("2-nin quvveti deyil");
//}











































//Hometask-Practise



//int[] arr = { 1, 2, 3, 6, 8, 9 };

//for (int i = 0; i< arr.Length; i++)
//{
//    if (arr[i] == 3)
//    {
//        Console.WriteLine("found - "    + arr[i]);
//        break;
//    }

//}



//int[] arr = { 1, 2, 3, 4, 3, 5, 6, 7, };
//int count = 0;

//for (int  i = 0; i  < arr.Length; i ++)
//{
//    if (arr[i] == 3)
//    {
//        count++;
//        if (count == 2)
//        {

//            Console.WriteLine("Found min 2 time  - "  + arr[i]);
//            break;
//        }


//    }


//}





//int a = 5;
//int b = a;
//b = 100;

//Console.WriteLine(a);
//Console.WriteLine(b);




//int[] arr1 = {1,2,3,4,5};

//int[] arr2 = arr1;

//arr2[0] = 200;

//Console.WriteLine(arr1[0]);
//Console.WriteLine(arr2[0]);




//string name1 = "test";

//string name2 = name1;

//name2 = "salam";

//Console.WriteLine(name1);
//Console.WriteLine(name2);


//var nme = "test";

//var age = 100;

//bool isMarried = false;




//int[] arr = { 1, 2, 3, 4, 5 };

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == 2)
//    {
//        continue;
//    }
//    Console.WriteLine(arr[i]);

//}



//1

//int n = 6;
//int result = 1;

//for (int i = 1; i <= n; i++)
//{

//       result *= i;


//}

//Console.WriteLine(result);



//2


//int[] arr = { 1, 2, 3, 5, 6, 8, 4, 5 };
//int result1 = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] %2 == 0)
//    {
//        result1 += arr[i];

//    }    




//}

//int kvadrat = result1 * result1;

//Console.WriteLine(kvadrat);



//3



//int n = 8;

//int quvvet = 1;

//while ( quvvet < n)
//{
//    quvvet *= 2;
//}

//if  (quvvet == n)
//{
//    Console.WriteLine("2nin quvvetidir");
//}
//else Console.WriteLine("2nin quvveti deyil");



//int n = 128;
//int quvvet = 1;

//while (quvvet < n)

//{
//    quvvet *= 2;

//}
//if (quvvet == n)
//{
//    Console.WriteLine("2nin quvvetidir");
//}
//else Console.WriteLine("2nin quvveti deyil");




//int[] arr = { 2, 5, 8, 12, 19 };
//int result = 0;
//for (int i =1; i< arr.Length; i++)

//{
//    int temp = 0;
//    temp = arr[i] - arr[i - 1];
//    if (temp>result)
//    {
//        result = temp;
//    }

//}
//Console.WriteLine(result);


//int n = 6;
//int m = 8;
//int result = 1;

//for  (int i =1; i< n*m; i++)
//{
//    if (i% n == 0 && i % m == 0)
//    {
//        result = i;
//        break;
//    }



//}
//Console.WriteLine(result);




















//int n = 5;
//int result = 1;


//for  (int i = 1; i<=n; i++)
//{
//    result *= i;

//}

//Console.WriteLine(result);


////int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 3 };
//int result = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//     if (arr[i] % 2 == 0)
//    {
//        result += arr[i];
//    }


//}
//int kvadrat = result * result;


//Console.WriteLine(kvadrat);


//3.


