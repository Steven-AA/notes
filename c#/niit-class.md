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