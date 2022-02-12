using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Dynamic;
using Microsoft.AspNetCore.Routing;

public static class Extensions
{
    public static ExpandoObject ToExpando(this object anonymousObject)
    {
        IDictionary<string, object> anonymousDictionary = new RouteValueDictionary(anonymousObject);
        IDictionary<string, object> expando = new ExpandoObject();
        foreach (var item in anonymousDictionary)
            expando.Add(item);
        return (ExpandoObject)expando;
    }

    public static List<dynamic> ToExpandoList<T>(this List<T> l)
    {
        return (from o in l select ToExpando(o)).ToList<dynamic>().ToList();
    }

    public static List<dynamic> ToExpandoList(this IQueryable<dynamic> query)
    {
        return query.ToList().ToExpandoList();
    }

    public static List<dynamic> ToExpandoList<T>(this IEnumerable<T> query)
    {
        return query.ToList().ToExpandoList();
    }
}
