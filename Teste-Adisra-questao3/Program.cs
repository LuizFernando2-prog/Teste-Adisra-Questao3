﻿int ff(int n)
{
    if (n == 1) return 1;
    if (n % 2 == 0) return ff(n / 2);
    return ff((n - 1) / 2) + ff((n + 1) / 2);
}
void main()
{
    printf("%d", ff(7));
    return;
}

/*
 Esse codigo nao compila, ja que esta escrito em C. Porem fiz um teste em Python e o retorno foi 3.
 */