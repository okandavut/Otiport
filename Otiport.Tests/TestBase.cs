using System;
using System.Collections.Generic;
using System.Text;
using AutoFixture;
using Moq;

namespace Otiport.Tests
{
    public abstract class TestBase
    {
        private readonly MockRepository _mockRepository;

        protected IFixture FixtureRepository { get; set; }

        public TestBase()
        {
            this._mockRepository = new MockRepository(MockBehavior.Strict);
            this.FixtureRepository = (IFixture)new Fixture();
            this.FinalizeSetUp();
        }


        protected Mock<T> MockFor<T>() where T : class
        {
            return this._mockRepository.Create<T>();
        }

        protected Mock<T> MockFor<T>(params object[] @params) where T : class
        {
            return this._mockRepository.Create<T>(@params);
        }

        protected T Create<T>()
        {
            return this.FixtureRepository.Create<T>();
        }

        protected IEnumerable<T> CreateMany<T>()
        {
            return this.FixtureRepository.CreateMany<T>();
        }

        protected IEnumerable<T> CreateMany<T>(int count)
        {
            return this.FixtureRepository.CreateMany<T>(count);
        }

        protected void EnableCustomization(ICustomization customization)
        {
            customization.Customize(this.FixtureRepository);
        }

        protected virtual void FinalizeTearDown()
        {
        }

        protected virtual void FinalizeSetUp()
        {
        }
    }
}

