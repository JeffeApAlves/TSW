using POSoftware.Infra;
using System.Collections.Generic;
using Tyco.Domain.Interfaces;
using Tyco.Infra.Repositories;

namespace Tyco.Application
{
    public class SupplierApplication : ApplicationBase
    {
        /// <summary>
        /// class para generalizacao de metodos comuns das calsse de aplicacoes
        /// </summary>

        private SupplierRepository _repository;
        private ISupplierRepository _irepository;


        public SupplierApplication()
        {
            _repository = new SupplierRepository();

            _irepository = _repository;
        }

        public SupplierApplication(ISupplierRepository supplierRepository)
        {
            _irepository = supplierRepository;
        }

        public void Register(Supplier supplier)
        {
            IEnumerable<Supplier> s = GetByCNPJ(supplier.CNPJ);

            _irepository.BeginTransaction();

            _irepository.Add(supplier);

            _irepository.Commit();
        }

        public void Remove(Supplier supplier)
        {
            _irepository.BeginTransaction();

            _irepository.Delete(supplier);

            _irepository.Commit();
        }


        public void Remove(int id)
        {
            _irepository.BeginTransaction();

            _irepository.Delete(id);

            _irepository.Commit();
        }

        public Supplier Get(int id)
        {
            _irepository.BeginTransaction();

            Supplier supplier = _irepository.Get(id);

            return supplier;
        }

        public IEnumerable<Supplier> Get()
        {
            _irepository.BeginTransaction();

            IEnumerable<Supplier> list_suppliers = _irepository.Get();

            return list_suppliers;
        }

        public IEnumerable<Supplier> GetByCNPJ(string cnpj)
        {
            _irepository.BeginTransaction();

            IEnumerable<Supplier> list_suppliers;

            if (cnpj == null || cnpj == "" || cnpj == " ")
            {
                list_suppliers = _irepository.Get();
            }
            else
            {
                list_suppliers = _irepository.GetByCNPJ(cnpj);
            }

            return list_suppliers;
        }

        public bool ExistCNPJ(string cnpj)
        {
            _irepository.BeginTransaction();

            IEnumerable<Supplier> list_suppliers;

            list_suppliers = _irepository.GetByCNPJ(cnpj);


            int c = 0;
            using (var e = list_suppliers.GetEnumerator())
            {
                while (e.MoveNext())
                    c++;
            }

            return c > 0;
        }

        public IEnumerable<Supplier> GetByData(string data)
        {
            _irepository.BeginTransaction();

            IEnumerable<Supplier> list_suppliers;

            if (data == null || data == "" || data == " ")
            {
                list_suppliers = _irepository.Get();
            }
            else
            {
                list_suppliers = _irepository.GetByData(data);
            }


            return list_suppliers;
        }

        public void Update(Supplier supplier)
        {
            _irepository.BeginTransaction();

            _irepository.Update(supplier);

            _irepository.Commit();
        }
    }
}
