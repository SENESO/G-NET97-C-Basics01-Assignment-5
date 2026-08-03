namespace Session05Assignment
    {
        class Program
        {
            static void Main(string[] args)
            {
                Book myBook = new Book();

                #region Question 1
                Console.WriteLine("--- Question 1 ---");
                // Console.WriteLine(myBook.password); 
                Console.WriteLine("Cannot print myBook.password.");
            /*
             * It causes a compilation error because private fields are only accessible within the containing class
             */
            #endregion

                #region Question 2
            Console.WriteLine("\n--- Question 2 ---");
                Console.WriteLine($"Copies in Stock: {myBook.copiesInStock}");
                #endregion

                #region Question 3
                Console.WriteLine("\n--- Question 3 ---");
                myBook.Title = "C# Programming Basics";
                Console.WriteLine($"Book Title: {myBook.Title}");
                #endregion

                #region Question 4
                Console.WriteLine("\n--- Question 4 ---");
                myBook.BookGenre = Genre.Science;
                Console.WriteLine($"Book Genre: {myBook.BookGenre}");
                #endregion

                #region Question 5
                Console.WriteLine("\n--- Question 5 ---");
                Console.WriteLine($"Underlying value of Fiction: {(int)Genre.Fiction}");
                Console.WriteLine($"Underlying value of NonFiction: {(int)Genre.NonFiction}");
                Console.WriteLine($"Underlying value of Science: {(int)Genre.Science}");
                #endregion

                #region Question 6
                Console.WriteLine("\n--- Question 6 ---");
                int genreNumber = 1;
                Genre castedGenre = (Genre)genreNumber;
                Console.WriteLine($"Integer {genreNumber} casted to Genre: {castedGenre}");
                #endregion

                #region Question 7
                Console.WriteLine("\n--- Question 7 ---");
                Genre genre = Genre.Fiction;
                string genreString = genre.ToString();
                Console.WriteLine($"Enum converted to string: {genreString}");
                #endregion

                #region Question 8
                Console.WriteLine("\n--- Question 8 ---");
                string genreText1 = "Science";
                Genre parsedGenre = (Genre)Enum.Parse(typeof(Genre), genreText1);
                Console.WriteLine($"String '{genreText1}' parsed to Enum: {parsedGenre}");
                #endregion

                #region Question 9
                Console.WriteLine("\n--- Question 9 ---");
                string genreText2 = "Mystery";
                if (Enum.TryParse(genreText2, out Genre tryParsedGenre))
                {
                    Console.WriteLine($"parsed: {tryParsedGenre}");
                }
                else
                {
                    Console.WriteLine("Unknown genre");
                }
                #endregion
            }
        }
    }
