nasm -f elf64 -o {NAME}.o {NAME}.asm

ld {NAME}.o -o {NAME}
