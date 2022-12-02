Assignment operators are used to assigning a value to a variable. The left side operand of the assignment operator is a variable and right side operand of the assignment operator is a value. The value on the right side must be of the same data-type of the variable on the left side otherwise the compiler will raise an error.

Different types of assignment operators are shown below:

    “=”(Simple Assignment): This is the simplest assignment operator. This operator is used to assign the value on the right to the variable on the left.
    Example:

      a = 10;
      b = 20;
      ch = 'y';

    “+=”(Add Assignment): This operator is combination of ‘+’ and ‘=’ operators. This operator first adds the current value of the variable on left to the value on the right and then assigns the result to the variable on the left.
    Example:

      (a += b) can be written as (a = a + b)

If initially value stored in a is 5. Then (a += 6) = 11.

    “-=”(Subtract Assignment): This operator is combination of ‘-‘ and ‘=’ operators. This operator first subtracts the current value of the variable on left from the value on the right and then assigns the result to the variable on the left.
    Example:

      (a -= b) can be written as (a = a - b)

If initially value stored in a is 8. Then (a -= 6) = 2.

    “*=”(Multiply Assignment): This operator is combination of ‘*’ and ‘=’ operators. This operator first multiplies the current value of the variable on left to the value on the right and then assigns the result to the variable on the left.
    Example:

      (a *= b) can be written as (a = a * b)

If initially value stored in a is 5. Then (a *= 6) = 30.

    “/=”(Division Assignment): This operator is combination of ‘/’ and ‘=’ operators. This operator first divides the current value of the variable on left by the value on the right and then assigns the result to the variable on the left.
    Example:

      (a /= b) can be written as (a = a / b)

If initially value stored in a is 6. Then (a /= 2) = 3.

    “%=”(Modulus Assignment): This operator is combination of ‘%’ and ‘=’ operators. This operator first modulo the current value of the variable on left by the value on the right and then assigns the result to the variable on the left.
    Example:

      (a %= b) can be written as (a = a % b)

If initially value stored in a is 6. Then (a %= 2) = 0.

    “<<=”(Left Shift Assignment) : This operator is combination of ‘<<‘ and ‘=’ operators. This operator first Left shift the current value of the variable on left by the value on the right and then assigns the result to the variable on the left.
    Example:

      (a <<= 2) can be written as (a = a << 2)

If initially value stored in a is 6. Then (a <<= 2) = 24.

    “>>=”(Right Shift Assignment) : This operator is combination of ‘>>’ and ‘=’ operators. This operator first Right shift the current value of the variable on left by the value on the right and then assigns the result to the variable on the left.
    Example:

      (a >>= 2) can be written as (a = a >> 2)

If initially value stored in a is 6. Then (a >>= 2) = 1.

    “&=”(Bitwise AND Assignment): This operator is combination of ‘&’ and ‘=’ operators. This operator first “Bitwise AND” the current value of the variable on the left by the value on the right and then assigns the result to the variable on the left.
    Example:

      (a &= 2) can be written as (a = a & 2)

If initially value stored in a is 6. Then (a &= 2) = 2.

    “^=”(Bitwise Exclusive OR): This operator is combination of ‘^’ and ‘=’ operators. This operator first “Bitwise Exclusive OR” the current value of the variable on left by the value on the right and then assigns the result to the variable on the left.
    Example:

      (a ^= 2) can be written as (a = a ^ 2)

If initially value stored in a is 6. Then (a ^= 2) = 4.

    “|=”(Bitwise Inclusive OR) : This operator is combination of ‘|’ and ‘=’ operators. This operator first “Bitwise Inclusive OR” the current value of the variable on left by the value on the right and then assigns the result to the variable on the left.
    Example :

      (a |= 2) can be written as (a = a | 2)

If initially, value stored in a is 6. Then (a |= 2) = 6.