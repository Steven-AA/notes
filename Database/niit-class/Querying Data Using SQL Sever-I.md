<!-- TOC -->

- [Querying Data Using SQL Sever-I](#querying-data-using-sql-sever-i)
    - [Chapter-1 Overview of SQL Sever](#chapter-1-overview-of-sql-sever)
    - [Chapter-2 Querying Data](#chapter-2-querying-data)
        - [Retrieving Data](#retrieving-data)
            - [Identifying Data Types](#identifying-data-types)
                - [Numberic](#numberic)
                - [Character and String](#character-and-string)
                - [Data and Time](#data-and-time)
                - [Binary](#binary)
                - [Other](#other)
            - [Retrieving Specific Attributes](#retrieving-specific-attributes)
                - [Rename](#rename)
                - [NEW](#new)
                - [Concatenating](#concatenating)
                - [Caculating](#caculating)
            - [Retrieving Select Rows](#retrieving-select-rows)
                - [Retrieving Records That Match a Pattern](#retrieving-records-that-match-a-pattern)
                - [Retrieving Records Contain NULL Values](#retrieving-records-contain-null-values)
                - [Retrieving Records to Displayed in a Sequence](#retrieving-records-to-displayed-in-a-sequence)
                - [Retrieving Records from the Top of a Table](#retrieving-records-from-the-top-of-a-table)
                - [Retrieving Records from a Particular Position](#retrieving-records-from-a-particular-position)
                - [Retrieving Records Without Duplication of Value](#retrieving-records-without-duplication-of-value)
        - [Using Functions to Customize the Result Set](#using-functions-to-customize-the-result-set)
            - [Using String Functions](#using-string-functions)
            - [Using Conversion Functions](#using-conversion-functions)
            - [Using Date Functions](#using-date-functions)
            - [Using Mathematical Functions](#using-mathematical-functions)
            - [Using Logical Functions](#using-logical-functions)
            - [Using Ranking Function](#using-ranking-function)
                - [row_number()](#row_number)
                - [rank()](#rank)
                - [dense_rank()](#dense_rank)
                - [ntile()](#ntile)
            - [Using Analytical Function](#using-analytical-function)
            - [Using System Function](#using-system-function)
        - [Summarizing and Grouping Data](#summarizing-and-grouping-data)
            - [Summarizing Data by Using Aggregate Functions](#summarizing-data-by-using-aggregate-functions)
            - [Grouping Data](#grouping-data)
                - [rollup](#rollup)
                - [cube](#cube)
                - [pivot](#pivot)
    - [Chapter-3 Querying Data by Using Hoins and Subqueries](#chapter-3-querying-data-by-using-hoins-and-subqueries)
        - [Querying Data by Using Joins](#querying-data-by-using-joins)
            - [Using an Inner Join](#using-an-inner-join)
                - [Using an Equi Join](#using-an-equi-join)
                - [Using a Self Join](#using-a-self-join)
            - [Using an Outer Join](#using-an-outer-join)
            - [Using a Cross Join](#using-a-cross-join)
        - [Querying Data by Using Subqueries](#querying-data-by-using-subqueries)
            - [Using the IN and EXISTS Keywords](#using-the-in-and-exists-keywords)
            - [Using Modified Comparison Operator](#using-modified-comparison-operator)
            - [Using Aggregate Functions](#using-aggregate-functions)
            - [Using Nested Subqueries](#using-nested-subqueries)
            - [Using Correlated Subqueries](#using-correlated-subqueries)
            - [Using the APPLY Operator](#using-the-apply-operator)
        - [Managing Result Sets](#managing-result-sets)
    - [Chapter-4 Managing Databases and Tables](#chapter-4-managing-databases-and-tables)
        - [Managing Databases](#managing-databases)
            - [Identifying System Databases in SQL Server](#identifying-system-databases-in-sql-server)
            - [Identifying the Database Files](#identifying-the-database-files)
            - [Creating a User-Defined Database](#creating-a-user-defined-database)
            - [Rename a User-Defined Database](#rename-a-user-defined-database)
            - [Dropping a User-Defined Database](#dropping-a-user-defined-database)
        - [Managing Tables](#managing-tables)
            - [Creating Table](#creating-table)
            - [Implementing Data Integrity](#implementing-data-integrity)
            - [Creating Synonyms](#creating-synonyms)
            - [Creating a Partition Table](#creating-a-partition-table)
            - [Modifying a Table](#modifying-a-table)
            - [Rename a Table](#rename-a-table)
            - [Dropping a Table](#dropping-a-table)
    - [Chapter-5 Manipulating Data in Tables](#chapter-5-manipulating-data-in-tables)
        - [Manipulating Data in a Table](#manipulating-data-in-a-table)
            - [Storing Data in a Table](#storing-data-in-a-table)
                - [Inserting Data in Related Tables](#inserting-data-in-related-tables)
                    - [Copy Table into a new Table](#copy-table-into-a-new-table)
                    - [Copy Table into existing Table](#copy-table-into-existing-table)
                - [Inserting Data in a Identity Column into a Table](#inserting-data-in-a-identity-column-into-a-table)
                - [Inserting the FILESTREAM Data](#inserting-the-filestream-data)
            - [Updating Data in a Table](#updating-data-in-a-table)
            - [Deleting Data Fron a Table](#deleting-data-fron-a-table)
                - [Deleting ALL](#deleting-all)
            - [Retrieving the Modified Data](#retrieving-the-modified-data)
            - [Comparing and Updating Data](#comparing-and-updating-data)
            - [Managing Hierarchical DatainTables](#managing-hierarchical-dataintables)
        - [Manipulating XML Data](#manipulating-xml-data)
    - [Chapter-6 Implementing Indexes, Views, and Full-Text Search](#chapter-6-implementing-indexes-views-and-full-text-search)

<!-- /TOC -->
# Querying Data Using SQL Sever-I
## Chapter-1 Overview of SQL Sever
## Chapter-2 Querying Data
---
### Retrieving Data
#### Identifying Data Types
- **Structured data**
- **Semi-structured data**
- **Unstructured data**
##### Numberic
##### Character and String
##### Data and Time
##### Binary
##### Other
#### Retrieving Specific Attributes
```sql
SELECT [ALL | DISTINCT] select_column_list 
[INTO [new_table_name]] 
From {table_name | view_name} 
[WHERE search_condition]
```
##### Rename
```sql
select A as 'a',...
select 'a' = A,...
select A 'a'...
```
##### NEW
    select A,'b',C,...
| A   | (No column name) | C   |
| --- | :--------------: | --- |
| ... |        b         | ... |
| ... |        b         | ... |
| ... |        b         | ... |
...
##### Concatenating
    select A + B + '...'
##### Caculating
    select A = 8*B
#### Retrieving Select Rows
    select A, B
    From CC
    Where A = 'a', B < 5 and B > 3
##### Retrieving Records That Match a Pattern
| Wildword | Description                    |
| :------- | :----------------------------- |
| %        | any zero or more character(s)  |
| _        | any single character           |
| []       | any single character in []     |
| [^]      | any single character not in [] |
    LIKE 'pattern'
##### Retrieving Records Contain NULL Values
    select A
    from B
    where A IS NULL
---
    select ISNULL(A,0.0)
##### Retrieving Records to Displayed in a Sequence
    select A
    from B
    order by A ASC|DESC (升序|降续)
    [order by ...]
##### Retrieving Records from the Top of a Table
    select [TOP 10[percent]] A
##### Retrieving Records from a Particular Position
@todo
##### Retrieving Records Without Duplication of Value
```sql
    select [all|distinct] A
    from ....
```
---
### Using Functions to Customize the Result Set
#### Using String Functions
    SELECT function_name (parameters)
```sql
| Function name                   |             Example             | Description       |
| :------------------------------ | :-----------------------------: | :---------------- |
| Ascii(character_expression)     |       select ascii('ABC')       | Return 65         |
| Char(integer_expression)        |         select char(65)         | Return 'A'        |
| Charindex('pattern',expression) |  select charindex('E','HELLO')  | Return 2          |
| Difference                      |                                 |                   |
| Left                            |                                 |                   |
| Len                             |                                 |                   |
| Lower                           |                                 |                   |
| Replace                         |                                 |                   |
| Replicate                       |                                 |                   |
| Patindex                        |                                 |                   |
| Reverse                         |                                 |                   |
| Right                           |                                 |                   |
| Rtrim                           |                                 | remove any blanks |
| Space                           |                                 |                   |
| Str                             |                                 |                   |
| Stuff                           |                                 |                   |
| Substring                       | SELECT Substring('weather',3,2) | return 'at'       |
| Upper                           |                                 |                   |
| Concat                          |                                 |                   |
```
#### Using Conversion Functions
| Function name                                  | Example | Description           |
| :--------------------------------------------- | :-----: | :-------------------- |
| Parse('' as date_type)                         |         |                       |
| Try_Parse('' as date_type)                     |         | return NULL if failed |
| Convert(datetype[(length)],expression[,style]) |         |                       |
| Try_convert                                    |         |                       |
@todo datetime
| Style value |  Format   |
| :---------: | :-------: |
|      1      | mm/dd/yyy |
|      2      | yy.mm.dd  |
|      3      | dd/mm/yyy |
|      4      | dd.mm.yy  |
|      5      | dd-mm-yy  |
#### Using Date Functions
| Function name                     |              Example              | Description             |
| :-------------------------------- | :-------------------------------: | :---------------------- |
| Dateadd(date part, number, date)  | SELECT dateadd(mm,3,'2009-01-01') |                         |
| datediff(date part, date1, date2) |                                   |                         |
| Datename(date part, date)         |                                   |                         |
| Datepart(date part, date)         |                                   |                         |
| Getdate()                         |                                   |                         |
| Day/Mounth/Year(date)             |                                   |                         |
| Getutcdate                        |                                   | return the current date |
| Datefromparts(year,date,month)    |                                   |                         |
| Datetimefromparts(...)            |                                   |                         |
| Eomonth(start_date[,month_toadd]) |                                   |                         |

#### Using Mathematical Functions
| Function name |     Example     | Description             |
| :------------ | :-------------: | :---------------------- |
| Abs(num)      |                 |                         |
| Ceiling(num)  |                 | smallest integer >= num |
| Exp(float)    | select exp(4.5) | return $e^(4.5)$        |

#### Using Logical Functions
| Function name | Example | Description |
| :------------ | :-----: | :---------- |
#### Using Ranking Function
##### row_number()
row_number() over(order by ...)
不考虑重复，连续编号
##### rank()
考虑重复，不连续编号
1 2 2 4 4 6 7 ...
##### dense_rank()
考虑重复，连续编号
1 2 2 3 3 4 5 。...
##### ntile()
ntile(n) 将所有数据平（尽可能）分成n组，编号靠前的数量多
#### Using Analytical Function
| Function name | Example | Description |
| :------------ | :-----: | :---------- |
略
#### Using System Function
| Function name | Example | Description |
| :------------ | :-----: | :---------- |
| host_id       |         |             |
| host_name     |         |             |
| suser_sid     |         |             |
| suser_id      |         |             |
| suser_sname   |         |             |
| user_id       |         |             |
...

2.50
---

### Summarizing and Grouping Data
#### Summarizing Data by Using Aggregate Functions
- 不能用在where子句
- Avg()
- Count()
- Min/Max()
- Sum()
#### Grouping Data
group by +聚合 不能加其他
having 组的筛选
```sql
GROUP BY
    GROUPNG SETS
    (
        (...,...,...),
        (...)
    )
```
##### rollup
##### cube
##### pivot
列转行@todo
```SQL

```
## Chapter-3 Querying Data by Using Hoins and Subqueries
### Querying Data by Using Joins
#### Using an Inner Join
- natural join 基于公共属性的等值连接，并去除多余属性
- join = inner join
```sql
SELECT ...
FROM a JOIN b ON a.1 = b.1
```
##### Using an Equi Join
##### Using a Self Join
#### Using an Outer Join
- 左外连接 保留左表所有行
- 右外连接 保留右表所有行
- 全外连接 保留两表所有行
#### Using a Cross Join
- 笛卡尔积
### Querying Data by Using Subqueries
#### Using the IN and EXISTS Keywords
#### Using Modified Comparison Operator
#### Using Aggregate Functions
#### Using Nested Subqueries
#### Using Correlated Subqueries
#### Using the APPLY Operator
```SQL
A [CROSS | OUTER] apply B
```

### Managing Result Sets

## Chapter-4 Managing Databases and Tables
### Managing Databases
#### Identifying System Databases in SQL Server
#### Identifying the Database Files
#### Creating a User-Defined Database
#### Rename a User-Defined Database
#### Dropping a User-Defined Database
### Managing Tables
#### Creating Table
#### Implementing Data Integrity
#### Creating Synonyms
#### Creating a Partition Table
#### Modifying a Table
#### Rename a Table
#### Dropping a Table

## Chapter-5 Manipulating Data in Tables
### Manipulating Data in a Table
#### Storing Data in a Table
```sql
INSERT [INTO] {table_name} [(column_list)]
VALUES {DEFAULT | values_list | select_statement}
```
##### Inserting Data in Related Tables
- 先在主键所在表添加数据
###### Copy Table into a new Table
```sql
SELECT * INTO new_table_name
FROM old_table_name
where ...
...
```
###### Copy Table into existing Table
```sql
INSERT INTO new_table_name
SELECT * FROM old_table_name
where ...
...
```
##### Inserting Data in a Identity Column into a Table
```sql
SET IDENTITY_INSERT Emp ON
```
##### Inserting the FILESTREAM Data
```sql
USE TekSoft
INSERT INTO A(a,b,c)
VALUES (NEWID(),b,c)
```
#### Updating Data in a Table
```sql
UPDATE table_name
SET column_name = value [,column_name = value]
[FROM table_name]
[WHERE condition]
```
#### Deleting Data Fron a Table
```sql
DELETE [FROM] table_name
[WHERE condition]
```
- 先在外键所在表删除数据
##### Deleting ALL
```sql
DELETE table_name
TRUNCATE TABLE table_name
```
#### Retrieving the Modified Data
@todo
#### Comparing and Updating Data
```sql
MERGE A AS TARGET
USING B AS　SOURCE
ON (TARGET.a = SOURCE.a)
WHEN MATCHED AND TARGET.b <> SOURCE.b
THEN 
@todo
```
#### Managing Hierarchical DatainTables
--
### Manipulating XML Data
E**x**tensible **M**arkup **L**anguage
- 只能有一个根元素
- 注释 <!-- -->
- Schema
## Chapter-6 Implementing Indexes, Views, and Full-Text Search