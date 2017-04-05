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
```
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
    ```
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
```
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
```
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
```
datatype[] Arrayname;
```
#### Intializing and Assigning Values to Array
##### Initializing Array
```
int[] Score;
Score = new int[10];
int[] Score = new int[10];
```
##### Assigning Values to the Array
```
Score[0] = 5;
int[] Score = new int[10]{0,1,2,...,9};
```
##### Copying an Array
```
int[] Score = new int[10]{0,1,2,...,9};
int[] Target = Source;
```
#### Manipulating Array Elements

##### foreach loop
##### Param Arrays
#### Multidimensional Arrays
##### The Array Class
|Property|Explanation|
|:-------|:----------|
|Length|return number|
|Rank|return dimension|
|IsFixedSize|
|IsReadOnly|
### Implementing Indexers
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
- overriding 改写 和 覆盖
    - 改写修改了基类???
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
派生类：
- @todo

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