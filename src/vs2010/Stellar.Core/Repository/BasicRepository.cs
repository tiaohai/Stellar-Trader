﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stellar.Core.Repository
{
    public class BasicRepository<T> : IRepository<T>
    {
        private ICollection<T> items;

        public BasicRepository(ICollection<T> collection)
        {
            items = collection;
        }

        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return items.Where(predicate);
        }

        public void Add(T item)
        {
            if (items.Count(i => i.Equals(item)) == 0)
                items.Add(item);
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }

        /// <summary>
        /// Unimplemented : There's no valid use for IDisposable in this implementation
        /// </summary>
        public void Dispose()
        {
            // GNDN
        }
    }
}
