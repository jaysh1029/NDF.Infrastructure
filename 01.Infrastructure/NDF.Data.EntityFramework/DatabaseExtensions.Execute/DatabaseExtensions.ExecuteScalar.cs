﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDF.Data.EntityFramework
{
    public static partial class DatabaseExtensions
    {

        /// <summary>
        /// 执行 <paramref name="command"/> 命令并根据执行结果返回查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略。
        /// </summary>
        /// <param name="database">表示一个 <see cref="System.Data.Entity.Database"/> 对象。</param>
        /// <param name="command">要被执行的 <see cref="DbCommand"/> 命令。</param>
        /// <returns>表示 <paramref name="command"/> 执行的查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略</returns>
        public static object ExecuteScalar(this Database database, DbCommand command)
        {
            return GetGeneralDatabase(database).ExecuteScalar(command);
        }

        /// <summary>
        /// 执行一个 SQL 脚本并根据执行结果返回查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略。
        /// </summary>
        /// <param name="database">表示一个 <see cref="System.Data.Entity.Database"/> 对象。</param>
        /// <param name="commandText">表示要执行的 SQL 脚本文本内容。</param>
        /// <returns>表示脚本命令执行的查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略</returns>
        public static object ExecuteScalar(this Database database, string commandText)
        {
            return GetGeneralDatabase(database).ExecuteScalar(commandText);
        }

        /// <summary>
        /// 以指定的脚本参数执行一个 SQL 脚本并根据执行结果返回查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略。
        /// </summary>
        /// <param name="database">表示一个 <see cref="System.Data.Entity.Database"/> 对象。</param>
        /// <param name="commandText">表示要执行的 SQL 脚本文本内容。</param>
        /// <param name="parameterValues">表示用于执行 <paramref name="commandText"/> 命令的参数列表。</param>
        /// <returns>表示脚本命令执行的查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略</returns>
        public static object ExecuteScalar(this Database database, string commandText, params DbParameter[] parameterValues)
        {
            return GetGeneralDatabase(database).ExecuteScalar(commandText, parameterValues);
        }

        /// <summary>
        /// 以指定的脚本参数执行一个 SQL 脚本并根据执行结果返回查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略。
        /// </summary>
        /// <param name="database">表示一个 <see cref="System.Data.Entity.Database"/> 对象。</param>
        /// <param name="commandText">表示要执行的 SQL 脚本文本内容。</param>
        /// <param name="parameterValues">表示用于执行 <paramref name="commandText"/> 命令的参数列表。</param>
        /// <returns>表示脚本命令执行的查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略</returns>
        public static object ExecuteScalar(this Database database, string commandText, params object[] parameterValues)
        {
            return GetGeneralDatabase(database).ExecuteScalar(commandText, parameterValues);
        }

        /// <summary>
        /// 以指定的脚本类型执行一个 SQL 脚本并根据执行结果返回查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略。
        /// </summary>
        /// <param name="database">表示一个 <see cref="System.Data.Entity.Database"/> 对象。</param>
        /// <param name="commandText">表示要执行的 SQL 脚本文本内容。</param>
        /// <param name="commandType">表示一个 <see cref="CommandType"/> 值用于指示 <paramref name="commandText"/> 的类型。</param>
        /// <returns>表示脚本命令执行的查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略</returns>
        public static object ExecuteScalar(this Database database, string commandText, CommandType commandType)
        {
            return GetGeneralDatabase(database).ExecuteScalar(commandText, commandType);
        }

        /// <summary>
        /// 以指定的脚本类型和参数执行一个 SQL 脚本并根据执行结果返回查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略。
        /// </summary>
        /// <param name="database">表示一个 <see cref="System.Data.Entity.Database"/> 对象。</param>
        /// <param name="commandText">表示要执行的 SQL 脚本文本内容。</param>
        /// <param name="commandType">表示一个 <see cref="CommandType"/> 值用于指示 <paramref name="commandText"/> 的类型。</param>
        /// <param name="parameterValues">表示用于执行 <paramref name="commandText"/> 命令的参数列表。</param>
        /// <returns>表示脚本命令执行的查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略</returns>
        public static object ExecuteScalar(this Database database, string commandText, CommandType commandType, params DbParameter[] parameterValues)
        {
            return GetGeneralDatabase(database).ExecuteScalar(commandText, commandType, parameterValues);
        }

        /// <summary>
        /// 以指定的脚本类型和参数执行一个 SQL 脚本并根据执行结果返回查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略。
        /// </summary>
        /// <param name="database">表示一个 <see cref="System.Data.Entity.Database"/> 对象。</param>
        /// <param name="commandText">表示要执行的 SQL 脚本文本内容。</param>
        /// <param name="commandType">表示一个 <see cref="CommandType"/> 值用于指示 <paramref name="commandText"/> 的类型。</param>
        /// <param name="parameterValues">表示用于执行 <paramref name="commandText"/> 命令的参数列表。</param>
        /// <returns>表示脚本命令执行的查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略</returns>
        public static object ExecuteScalar(this Database database, string commandText, CommandType commandType, params object[] parameterValues)
        {
            return GetGeneralDatabase(database).ExecuteScalar(commandText, commandType, parameterValues);
        }


        /// <summary>
        /// 作为事务处理的一部分以指定的脚本类型和参数执行 <paramref name="command"/> 命令并根据执行结果返回查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略。
        /// </summary>
        /// <param name="database">表示一个 <see cref="System.Data.Entity.Database"/> 对象。</param>
        /// <param name="transaction">用于包含脚本命令的 <see cref="DbTransaction"/> 对象。</param>
        /// <param name="command">要被执行的 <see cref="DbCommand"/> 命令。</param>
        /// <returns>表示脚本命令执行的查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略</returns>
        public static object ExecuteScalar(this Database database, DbTransaction transaction, DbCommand command)
        {
            return GetGeneralDatabase(database).ExecuteScalar(transaction, command);
        }

        /// <summary>
        /// 作为事务处理的一部分以指定的脚本类型执行一个 SQL 脚本并根据执行结果返回查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略。
        /// </summary>
        /// <param name="database">表示一个 <see cref="System.Data.Entity.Database"/> 对象。</param>
        /// <param name="transaction">用于包含脚本命令的 <see cref="DbTransaction"/> 对象。</param>
        /// <param name="commandText">表示要执行的 SQL 脚本文本内容。</param>
        /// <returns>表示脚本命令执行的查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略</returns>
        public static object ExecuteScalar(this Database database, DbTransaction transaction, string commandText)
        {
            return GetGeneralDatabase(database).ExecuteScalar(transaction, commandText);
        }

        /// <summary>
        /// 作为事务处理的一部分以指定的脚本参数执行一个 SQL 脚本并根据执行结果返回查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略。
        /// </summary>
        /// <param name="database">表示一个 <see cref="System.Data.Entity.Database"/> 对象。</param>
        /// <param name="transaction">用于包含脚本命令的 <see cref="DbTransaction"/> 对象。</param>
        /// <param name="commandText">表示要执行的 SQL 脚本文本内容。</param>
        /// <param name="parameterValues">表示用于执行 <paramref name="commandText"/> 命令的参数列表。</param>
        /// <returns>表示脚本命令执行的查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略</returns>
        public static object ExecuteScalar(this Database database, DbTransaction transaction, string commandText, params DbParameter[] parameterValues)
        {
            return GetGeneralDatabase(database).ExecuteScalar(transaction, commandText, parameterValues);
        }

        /// <summary>
        /// 作为事务处理的一部分以指定的脚本参数执行一个 SQL 脚本并根据执行结果返回查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略。
        /// </summary>
        /// <param name="database">表示一个 <see cref="System.Data.Entity.Database"/> 对象。</param>
        /// <param name="transaction">用于包含脚本命令的 <see cref="DbTransaction"/> 对象。</param>
        /// <param name="commandText">表示要执行的 SQL 脚本文本内容。</param>
        /// <param name="parameterValues">表示用于执行 <paramref name="commandText"/> 命令的参数列表。</param>
        /// <returns>表示脚本命令执行的查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略</returns>
        public static object ExecuteScalar(this Database database, DbTransaction transaction, string commandText, params object[] parameterValues)
        {
            return GetGeneralDatabase(database).ExecuteScalar(transaction, commandText, parameterValues);
        }

        /// <summary>
        /// 作为事务处理的一部分以指定的脚本类型执行一个 SQL 脚本并根据执行结果返回查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略。
        /// </summary>
        /// <param name="database">表示一个 <see cref="System.Data.Entity.Database"/> 对象。</param>
        /// <param name="transaction">用于包含脚本命令的 <see cref="DbTransaction"/> 对象。</param>
        /// <param name="commandText">表示要执行的 SQL 脚本文本内容。</param>
        /// <param name="commandType">表示一个 <see cref="CommandType"/> 值用于指示 <paramref name="commandText"/> 的类型。</param>
        /// <returns>表示脚本命令执行的查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略</returns>
        public static object ExecuteScalar(this Database database, DbTransaction transaction, string commandText, CommandType commandType)
        {
            return GetGeneralDatabase(database).ExecuteScalar(transaction, commandText, commandType);
        }

        /// <summary>
        /// 作为事务处理的一部分以指定的脚本类型和参数执行一个 SQL 脚本并根据执行结果返回查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略。
        /// </summary>
        /// <param name="database">表示一个 <see cref="System.Data.Entity.Database"/> 对象。</param>
        /// <param name="transaction">用于包含脚本命令的 <see cref="DbTransaction"/> 对象。</param>
        /// <param name="commandText">表示要执行的 SQL 脚本文本内容。</param>
        /// <param name="commandType">表示一个 <see cref="CommandType"/> 值用于指示 <paramref name="commandText"/> 的类型。</param>
        /// <param name="parameterValues">表示用于执行 <paramref name="commandText"/> 命令的参数列表。</param>
        /// <returns>表示脚本命令执行的查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略</returns>
        public static object ExecuteScalar(this Database database, DbTransaction transaction, string commandText, CommandType commandType, params DbParameter[] parameterValues)
        {
            return GetGeneralDatabase(database).ExecuteScalar(transaction, commandText, commandType, parameterValues);
        }

        /// <summary>
        /// 作为事务处理的一部分以指定的脚本类型和参数执行一个 SQL 脚本并根据执行结果返回查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略。
        /// </summary>
        /// <param name="database">表示一个 <see cref="System.Data.Entity.Database"/> 对象。</param>
        /// <param name="transaction">用于包含脚本命令的 <see cref="DbTransaction"/> 对象。</param>
        /// <param name="commandText">表示要执行的 SQL 脚本文本内容。</param>
        /// <param name="commandType">表示一个 <see cref="CommandType"/> 值用于指示 <paramref name="commandText"/> 的类型。</param>
        /// <param name="parameterValues">表示用于执行 <paramref name="commandText"/> 命令的参数列表。</param>
        /// <returns>表示脚本命令执行的查询所返回的结果集中的第一行第一列。所有其他的行和列将会被忽略</returns>
        public static object ExecuteScalar(this Database database, DbTransaction transaction, string commandText, CommandType commandType, params object[] parameterValues)
        {
            return GetGeneralDatabase(database).ExecuteScalar(transaction, commandText, commandType, parameterValues);
        }

    }
}
