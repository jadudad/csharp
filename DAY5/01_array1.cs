using static System.Console;


// 배열의 종류 ( 173 ~ )

// #1. 일차 배열(single-dimension array)
int[] arr1 = { 1, 2, 3 };
arr1[0] = 10;


// #2. 다차 배열(multi-dimensional array)
int[,] arr2 = { { 1, 2 }, { 3, 4 } };
arr2[0, 0] = 10;
// C 언어: arr2[0][0]


// #3. 가변 배열(jagged array)
// => 배열의 배열
int[][] arr3 = new int[3][];         // 3개 크기 배열인데, "요소가 배열"
arr3[0] = new int[2] { 1, 2 };
arr3[1] = new int[3] { 1, 2, 3 };
arr3[2] = new int[4] { 1, 2, 3, 4 };
arr3[0][0] = 0;


