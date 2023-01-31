section .data
	userMsg db "Please enter a number: "
	lenUserMsg equ $-userMsg
	dispMsg db "You have enterd: "
	lenDispMsg equ $-dispMsg

section .bss
	num resb 10

section .text
	global _start

_start:
	mov eax, 4
	mov ebx, 1
	mov ecx, userMsg
	mov edx, lenUserMsg
	int 80h

	mov eax, 3
	mov ebx, 1
	mov ecx, num
	mov edx, 10
	int 80h

	mov eax, 4
	mov ebx, 1
	mov ecx, dispMsg
	mov edx, lenDispMsg
	int 80h

	mov eax, 4
	mov ebx, 1
	mov ecx, num
	mov edx, 10
	int 80h

	mov eax, 4
	mov ebx, 1
	mov ecx, 0xa
	mov edx, 0
	int 80h

	mov eax, 1
	mov ebx, 0
	int 80h
