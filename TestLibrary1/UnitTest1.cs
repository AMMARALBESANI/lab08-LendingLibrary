using LendingLibrary.Casses;

namespace TestLibrary1
{
    public class UnitTest1
    {
        [Fact]
        public void AddaBooktoyourLibrary()
        {
            //Arrange
            Library library = new Library();
            library.Add("love", "Ammar", "albesani", 50);
            int result = library.Count();
            
            //ASSERT

            Assert.Equal(1,result );

        }

        [Fact]

        public void BorrowingAnExistingBook()
        {
            //Arrange
            Library library = new Library();
            library.Add("love", "Ammar", "albesani", 50);
            library.Add("love1", "Ammar", "albesani", 50);
            library.Add("love2", "Ammar", "albesani", 50);
            int count = 2;
            int result = library.Count();
            //Act
            library.Borrow("love");

            //ASSERT

            Assert.Equal( count, library.Count());

            //Act
            library.Return(new Book("love", "Ammar", "albesani", 50));

            //ASSERT
            Assert.Equal(result, 3);


        }

        

        [Fact]

        public void BorrowingamissingBook()
        {
            //Arrange
            Library library = new Library();
            library.Add("love", "Ammar", "albesani", 50);
            library.Add("love1", "Ammar", "albesani", 50);
            library.Add("love2", "Ammar", "albesani", 50);


            //Act
            library.Borrow("love3");
            library.Borrow("love1");
            library.Return(new Book("love1", "Ammar", "albesani", 50));

            //ASSERT
            Assert.Equal( null, library.Borrow("love3") );
        }



        [Fact]  

        public void backAndUnbackABook() 
        {
            //Arrange
            BackPack<Book> backpack = new BackPack<Book>();
            backpack.Pack(new Book("why", "Ammar", "albesani", 50));
            backpack.Pack(new Book("because", "Ammar", "albesani", 50));
            backpack.Pack(new Book("reasons", "Ammar", "albesani", 50));
            int addind= backpack.Count<Book>();
            backpack.Unpack(2);
            int number = backpack.Count<Book>();  
            //assert
            Assert.Equal(3, addind);
            Assert.Equal(2, number);
        }
    }
}