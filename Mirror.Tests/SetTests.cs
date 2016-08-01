﻿using Mirror.Tests.TestClasses;
using Xunit;

namespace ConstructionSet.Tests
{
    public class SetTests
    {
        private readonly ClassWithPrivateFields target = new ClassWithPrivateFields();
        private readonly int valueToSet = 123;

        [Fact]
        public void CanSetInstanceFieldValue()
        {
            // Arrange
            var fieldName = ClassWithPrivateFields.InstanceFieldName;

            // Act
            Set.FieldValue(target, fieldName, valueToSet);

            // Assert
            Assert.Equal(target.DirectInstanceField, valueToSet);
        }

        [Fact]
        public void CanSetStaticFieldValue()
        {
            // Arrange
            var fieldName = ClassWithPrivateFields.StaticFieldName;

            // Act
            Set.StaticFieldValue<ClassWithPrivateFields>(fieldName, valueToSet);

            // Assert
            Assert.Equal(ClassWithPrivateFields.DirectStaticField, valueToSet);
        }

        [Fact]
        public void CanSetInstanceProperty()
        {
            // Arrange
            var propertyName = ClassWithPrivateFields.InstancePropertyName;

            // Act
            Set.PropertyValue(target, propertyName, valueToSet);

            // Assert
            Assert.Equal(target.DirectInstanceProperty, valueToSet);
        }

        [Fact]
        public void CanSetStaticProperty()
        {
            // Arrange
            var propertyName = ClassWithPrivateFields.StaticPropertyName;

            // Act
            Set.StaticPropertyValue<ClassWithPrivateFields>(propertyName, valueToSet);

            // Assert
            Assert.Equal(ClassWithPrivateFields.DirectStaticProperty, valueToSet);
        }
    }
}
