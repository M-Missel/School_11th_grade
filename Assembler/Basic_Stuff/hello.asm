
section .data
	text db "Hello World!", 0Ah

section .data2
	text2 db "Test text", 0Ah

section .text
	global _start

_start:
	mov rax, 1
	mov rdi, 1
	mov rsi, text
	mov rdx, 14
	syscall

	mov rax, 1
	mov rdi, 1
	mov rsi, text2
	mov rdx, 12
	syscall

	mov rax, 60
	mov rdi, 0
	syscall

