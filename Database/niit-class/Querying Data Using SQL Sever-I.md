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
```
SELECT [ALL | DISTINCT] select_column_list 
[INTO [new_table_name]] 
From {table_name | view_name} 
[WHERE search_condition]
```
##### Rename
```
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
| Function name                                                      |              Example              | Description             |
| :----------------------------------------------------------------- | :-------------------------------: | :---------------------- |
| Dateadd(date part, number, date)                                   | SELECT dateadd(mm,3,'2009-01-01') |                         |
| datediff(date part, date1, date2)                                  |                                   |                         |
| Datename(date part, date)                                          |                                   |                         |
| Datepart(date part, date)                                          |                                   |                         |
| Getdate()                                                          |                                   |                         |
| Day/Mounth/Year(date)                                              |                                   |                         |
| Getutcdate                                                         |                                   | return the current date |
| Datefromparts(year,date,month)                                     |                                   |                         |
| Datetimefromparts(year,month,day,hour,minute,seconds,milliseconds) |                                   |                         |
| Eomonth(start_date[,month_toadd])                                  |                                   |                         |

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