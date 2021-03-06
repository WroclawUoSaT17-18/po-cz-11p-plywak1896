// <copyright file="MainWindowTest.cs">Copyright ©  2018</copyright>
using System;
using Clientnaokienkach;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Clientnaokienkach.Tests
{
    /// <summary>Ta klasa zawiera sparametryzowane testy jednostek dla MainWindow</summary>
    [PexClass(typeof(MainWindow))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class MainWindowTest
    {
    }
}
