// Type Constraint
// 특정 조건을 갖춘 형식
// where

class MyClass1<T> where T : struct { }
class MyClass2<T> where T : class { }

class MyClass3<T, U>
    where T : struct
    where U : class
{ }


