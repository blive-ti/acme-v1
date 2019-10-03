using Blive.Acme.App.Controllers;
using Blive.Acme.App.Models;
using Blive.Acme.App.Repository;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace Blive.Acme.Test
{
    public class SampleTest
    {
        [Fact]
        public void Sum_SameNumber_ShouldReturnDoubleOfNumber()
        {
            // Arrange
            int i = 2;
            int result;

            // Act
            result = i + i;

            // Assert
            Assert.Equal(i * 2, result);
        }

    }
}
