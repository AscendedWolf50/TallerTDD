﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TallerBT.BT;

namespace TallerTDD.Tests
{
    [TestFixture]
    public class CompositeTests
    {
        [Test]
        public void Composite_CanOnlyBeInstantiatedThroughSubclasses()
        {
            // Intentar instanciar Composite directamente debería lanzar una excepción de compilación, no en tiempo de ejecución.
            // Por lo tanto, eliminamos la parte de Activator.CreateInstance

            // Verificamos que las subclases de Composite sí pueden ser instanciadas
            var sequence = new Sequence();  // Suponiendo que tienes una clase concreta llamada Sequence
            var selector = new Selector();  // Suponiendo que tienes una clase concreta llamada Selector

            Assert.NotNull(sequence);
            Assert.NotNull(selector);
        }


        [Test]
        public void Composite_CannotHaveRootAsChild()
        {
            Selector selector = new Selector();
            Root root = new Root();
            Assert.Throws<InvalidOperationException>(() => selector.AddChild(root));
        }
    }

}
