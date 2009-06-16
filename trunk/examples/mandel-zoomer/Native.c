// Copyright (C) 2009 Jesse Jones
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

#ifdef LIBGMP
#include <gmp.h>
#endif
#include <stdio.h>

typedef struct
{
	double startX;
	double startY;
	double dx;
	double dy;
	double bailout;
	int h;
	int v;
	int maxDwell;
} SmallInfo;

// Note that this is about 3x faster than the release C# equivalent.
// [ThreadModel(ThreadModel.SingleThread)]
void SmallCompute(SmallInfo info, double* outMag, unsigned short* outDwell)
{
	double x0 = info.startX + info.h*info.dx;
	double y0 = info.startY - info.v*info.dy;
	
	double x = x0;
	double y = y0;
	
	double mag = 0.0;
	unsigned short dwell = 0;

	while (mag < info.bailout && dwell < info.maxDwell)
	{
		double temp = x*x - y*y + x0;
		y = 2*x*y + y0;
		
		x = temp;
		mag = x*x + y*y;
		++dwell;
	}
	
	*outMag = mag;
	*outDwell = dwell;
}

#ifdef LIBGMP
typedef struct
{
	__mpf_struct startX;
	__mpf_struct startY;
	__mpf_struct dx;
	__mpf_struct dy;
	__mpf_struct bailout;
	int h;
	int v;
	int maxDwell;
} BigInfo;

// At 64 bits this is about 14x slower than SmallCompute.
// [ThreadModel(ThreadModel.SingleThread)]
void BigCompute(BigInfo info, double* outMag, unsigned short* outDwell)
{
	mpf_t x0, y0, x, y, mag, temp, t1, t2;
	unsigned short dwell = 0;
	unsigned long prec = mpf_get_prec(&info.dx);
	
	mpf_init2(x0, prec);
	mpf_init2(y0, prec);
	mpf_init2(x, prec);
	mpf_init2(y, prec);
	mpf_init2(mag, prec);
	mpf_init2(temp, prec);
	mpf_init2(t1, prec);
	mpf_init2(t2, prec);
	
	// x0 = info.startX + info.h*info.dx
	mpf_mul_ui(temp, &info.dx, info.h);
	mpf_add(x0, &info.startX, temp);
	
	// y0 = info.startY - info.v*info.dy
	mpf_mul_ui(temp, &info.dy, info.v);
	mpf_sub(y0, &info.startY, temp);
	
	// x = x0
	mpf_set(x, x0);
	
	// y = y0
	mpf_set(y, y0);
	
	while (mpf_cmp(mag, &info.bailout) < 0 && dwell < info.maxDwell)
	{
		// temp = x*x - y*y + x0
		mpf_mul(t1, x, x);
		mpf_mul(t2, y, y);
		mpf_sub(temp, t1, t2);
		mpf_add(temp, temp, x0);
		
		// y = 2*x*y + y0
		mpf_mul_ui(t1, x, 2);
		mpf_mul(t1, t1, y);
		mpf_add(y, t1, y0);
		
		// x = temp
		mpf_set(x, temp);
		
		// mag = x*x + y*y
		mpf_mul(t1, x, x);
		mpf_mul(t2, y, y);
		mpf_add(mag, t1, t2);
		
		++dwell;
	}
	
	*outMag = mpf_get_d(mag);
	*outDwell = dwell;
	
	mpf_clear(x0);
	mpf_clear(y0);
	mpf_clear(x);
	mpf_clear(y);
	mpf_clear(mag);
	mpf_clear(temp);
	mpf_clear(t1);
	mpf_clear(t2);
}
#endif

#if 0
// gcc -o app.exe -m32 -lgmp *.c
int main()
{
	printf("int: %lu\n", sizeof(int));			// 4
	printf("long: %lu\n", sizeof(long));	// 4
	printf("size_t: %lu\n", sizeof(size_t)); // 4
#ifdef LIBGMP
	printf("mp_exp_t: %lu\n", sizeof(mp_exp_t));	// 4
	printf("__mpf_struct: %lu\n", sizeof(__mpf_struct)); // 16
#endif
	
	return 0;
}
#endif
