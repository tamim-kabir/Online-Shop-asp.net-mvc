using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Online_shop_mvc.Repository
{
    public interface IRepository<Tbl_Entity> where Tbl_Entity:class
    {
        IEnumerable<Tbl_Entity> GetAllRecords();
        IQueryable<Tbl_Entity> GetAllRecordsIQueryable();
        int GetAllRecordsCount();
        void Add(Tbl_Entity entity);
        void Update(Tbl_Entity entity);
        void UpdateByWhareClause(Expression<Func<Tbl_Entity, bool>> wherePredict, Action<Tbl_Entity> ForEachPredict);
        Tbl_Entity GetFirstOrDefault(int recordId);
        void Remove(Tbl_Entity entity);
        void RemoveByWhereclause(Expression<Func<Tbl_Entity, bool>> wherePredict);
        void RemoveRangeByWhereclause(Expression<Func<Tbl_Entity, bool>> wherePredict);
        void InactiveAnddeleteMarkByWhereClause(Expression<Func<Tbl_Entity,bool>> wherePredict, Action<Tbl_Entity> ForEachPredict);
        Tbl_Entity GetFirstOrDefaultByParameter(Expression<Func<Tbl_Entity, bool>> wherePredict);
        IEnumerable<Tbl_Entity> GetListParameter(Expression<Func<Tbl_Entity, bool>> wherePredict);
        IEnumerable<Tbl_Entity> GetResultBySqlProcedure(string query, params object[] paramiters);
        IEnumerable<Tbl_Entity> GetRecordsToShow(int pageNO, int pageSize, int currentPage, Expression<Func<Tbl_Entity, bool>> wherePredict, Expression<Func<Tbl_Entity, int>> orderByPredict);
    }
}
