<!-- TOC -->

- [Programing with C](#programing-with-c)
    - [-1- Introduce to C](#-1--introduce-to-c)
    - [-2- Operators and Programming Constructs](#-2--operators-and-programming-constructs)
    - [-3- Working with Class Members](#-3--working-with-class-members)
        - [](#)
        - [Working with Properties](#working-with-properties)
            - [Defining Properties](#defining-properties)
    - [-4- Creating Value Types and Reference Types](#-4--creating-value-types-and-reference-types)
        - [Describing Memory Allocation](#describing-memory-allocation)
            - [程序占用的内存](#程序占用的内存)
        - [Using Structures](#using-structures)
            - [结构体与类的区别 @todo](#结构体与类的区别-todo)
        - [Using Enumerations //枚举类型](#using-enumerations-枚举类型)
            - [性质](#性质)
            - [枚举类型与基础类型的转换](#枚举类型与基础类型的转换)
        - [Implementing Arrays](#implementing-arrays)
            - [Declaring an Array](#declaring-an-array)
            - [Intializing and Assigning Values to Array](#intializing-and-assigning-values-to-array)
                - [Initializing Array](#initializing-array)
                - [Assigning Values to the Array](#assigning-values-to-the-array)
                - [Copying an Array](#copying-an-array)
            - [Manipulating Array Elements](#manipulating-array-elements)
                - [foreach loop](#foreach-loop)
                - [Param Arrays](#param-arrays)
            - [Multidimensional Arrays](#multidimensional-arrays)
                - [The Array Class](#the-array-class)
        - [Implementing Indexers](#implementing-indexers)
        - [Using Collections](#using-collections)
        - [Implementing Generics](#implementing-generics)
    - [-5- Extending Existing Classes](#-5--extending-existing-classes)
        - [Implementing Inheritance](#implementing-inheritance)
        - [Using Abstract Class](#using-abstract-class)
            - [Using Abstract Methods](#using-abstract-methods)
            - [Using Virtual Function 虚方法](#using-virtual-function-虚方法)
        - [Using Sealed Class](#using-sealed-class)
            - [Using Sealed Class](#using-sealed-class-1)
        - [Using Interfaces](#using-interfaces)
    - [-6- Implementing Polymorphism](#-6--implementing-polymorphism)
        - [Implementing Function Overloading](#implementing-function-overloading)
        - [Implementing Operator Overloading](#implementing-operator-overloading)
        - [Implementing Overriding](#implementing-overriding)
    - [-7- File Input and Output](#-7--file-input-and-output)
        - [Implementing the File Input and Output Operations](#implementing-the-file-input-and-output-operations)
        - [Implementing Reading and writing the Text Files](#implementing-reading-and-writing-the-text-files)
        - [Implementing Implenemnt Reading and writing in Binary Files](#implementing-implenemnt-reading-and-writing-in-binary-files)
        - [Implementing the Windows File System](#implementing-the-windows-file-system)
    - [-8- Exception Handing](#-8--exception-handing)
        - [Describing Exceptions](#describing-exceptions)
        - [Handing Exceptions](#handing-exceptions)
        - [Implementing the User-defined Exceptions](#implementing-the-user-defined-exceptions)

<!-- /TOC -->
---
# Programing with C#
## -1- Introduce to C#
## -2- Operators and Programming Constructs
## -3- Working with Class Members
### 
### Working with Properties
#### Defining Properties
- attribute 属性
```csharp
private int x;
public class X
{
    get
    {
        return x;
    }
    set
    {
        x = value;//input
    }
}
...
... Main
{
    MyClass mc = new MyClass();
    mc.X = 10;//set
    int xVal = mc.X;//get
}
...
```

## -4- Creating Value Types and Reference Types
### Describing Memory Allocation
- **Value Types** : 
- **Reference Types** : address
    ```csharp
    Car Ford = new Car();
    Car Fuuuuu;
    Fuuuuu = Ford;//指向同一个空间
    ```
#### 程序占用的内存
- 代码区
- 静态存储区
- **堆区（heap）** 链表结构
- **栈区（stack）**
>All value tyoes are created on the stack. Stack memory is organized like a stack of books piled on a rack.
### Using Structures
- **value types** and stored in **stack**
- do **NOT** support **inheritance**
- **CANNOT** have default constructor @Q
#### 结构体与类的区别 @todo
- 

### Using Enumerations //枚举类型
```csharp
public enum name: 基础类型(default:int)
{

};
enum days{sat, sun, ..., fri};
//         0    1   ...   6
```
#### 性质
- 允许有相同的值，不允许有相同的名
- 每一个枚举成员都都具有相关联的常数值
#### 枚举类型与基础类型的转换
- 基础类型和枚举类型不能相互隐式转换
```csharp
public enum Number{a, b, c, d};
...
...Main
{
    int i = (int)Number.a;//i = 0
    Number n = (Number)2;//n = c
}
...
```
### Implementing Arrays
- **reference types**
#### Declaring an Array
```csharp
datatype[] Arrayname;
```
#### Intializing and Assigning Values to Array
##### Initializing Array
```csharp
int[] Score;
Score = new int[10];
int[] Score = new int[10];
```
##### Assigning Values to the Array
```csharp
Score[0] = 5;
int[] Score = new int[10]{0,1,2,...,9};
```
##### Copying an Array
```csharp
int[] Score = new int[10]{0,1,2,...,9};
int[] Target = Source;
```
#### Manipulating Array Elements

##### foreach loop
##### Param Arrays
#### Multidimensional Arrays
##### The Array Class
| Property    | Explanation      |
| :---------- | :--------------- |
| Length      | return number    |
| Rank        | return dimension |
| IsFixedSize |                  |
| IsReadOnly  |                  |

| Method    | Explanation |
| :-------- | :---------- |
| Sort      |             |
| Clear     |             |
| GetLength |             |
| GetValue  |             |
| IndexOf   |             |

### Implementing Indexers
```csharp
...
class indexers
{
    private string []name = new string[5];
    public string this [int index]
    {
        get
        {
            return name[index];
        }
        set
        {
            name[index]=value;
        }
    }
}
class Main
{
    public static void Main()
    {
        indexers ind = new Indexers();
        ind[0] = "Jhon";
        ...
    }
}
```
### Using Collections
### Implementing Generics
## -5- Extending Existing Classes
---
temp note
- 没有虚类
- 抽象类中，抽象函数必须是public的
- 实方法不能被改写，但可以被覆盖
- sealed以后不可以被override，但是可以覆盖
- 抽象函数被override后，基类的该函数已被改写
- 虚函数被override后，基类的该函数无影响
---

- Interfaces Relationship 继承关系
- Composition Relationship 组合关系
    - 父类消失，子类也消失
- Utilization Relationship 使用关系
- Instantiation Relationship 实例关系
### Implementing Inheritance
```
base class --> derived class
automobile --> Car
```
Interfaces Relationship 继承关系：
- 一个类只能有一个父类
- overriding 改写
- new 覆盖
- 子类可访问父类 protected
- 继承可传递
- 派生类是基类的扩展
- 构造函数和析构函数不能被继承
- 派生类可以覆盖已继承成员
- 类可以定义虚方法、虚属性、虚索引器
- 先执行父类的构造函数，再执行子类的构造函数
- 先执行子类的析构函数，再执行父类的析构函数
```
class <derived_class> : <base_class>
```

### Using Abstract Class
- 不能实例化
- 只能在抽象类中声明抽象方法
- 不能密封 sealed
- 一个非抽象类从抽象类中派生，必须重写（override）所有继承而来的抽象成员
#### Using Abstract Methods
```
public abstract return-type method-name(...);
```
#### Using Virtual Function 虚方法
```
virtual return-type method-name(...){...}
```
### Using Sealed Class
```
sealed class-name(...);
```
- 密封类不可能有派生类
- 虚函数无效，转为非虚
#### Using Sealed Class

### Using Interfaces
- **Interfaces** are used when a standard structure of methods is to be followed by the classes, and where classes will implement the functionality.
- **Abstract classes** are used when you want only a few methods to declare by the base class and the derived class will implement the functionality.
- 接口成员的申明不能使用任何访问修饰符，实现接口时加访问修饰符
- 显示接口成员只能通过接口调用


## -6- Implementing Polymorphism
### Implementing Function Overloading
- 参数数量、类型、排列顺序不同
- 返回类型不同不算
### Implementing Operator Overloading
### Implementing Overriding
## -7- File Input and Output
### Implementing the File Input and Output Operations
### Implementing Reading and writing the Text Files
### Implementing Implenemnt Reading and writing in Binary Files
### Implementing the Windows File System
## -8- Exception Handing
### Describing Exceptions
### Handing Exceptions
### Implementing the User-defined Exceptions 
