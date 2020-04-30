using System;
using Xunit;

namespace Fisher.Bookstore.Tests
{
    public class BookTests
    {
        [Fact]
        public void TeamMemberDiscount()
        {
            //Arrange
            var book = new Book()
            {
                Id = 1, 
                Title = "my other test book",
                Price = 9.99
            }
            book.ApplyMemberDiscount();
        //assert
        var discountPrice = 9.99 * .9;
        Assert.Equal(discountPrice, book.Price);
       
        }
        public void AddBookPrice()
        {
            // arrange
            var book = new Book()
            {
                Id = 1,
                Title = "My Test Book",
                Price = 9.99
            }
            // act
            book.Price = 7.99;

            // assert
            Assert.Equal(7.99, book.Price);

        }
    }
}
