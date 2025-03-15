function multiply(a, b) {
    // Base case: If b is 0, the result is 0
    if (b === 0) {
        return 0;
    }
    // If b is negative, handle negative multiplication
    if (b < 0) {
        return -multiply(a, -b);
    }
    // Recursive case: Add `a` one less time
    return a + multiply(a, b - 1);
}

// Example usage
console.log(multiply(5, 3)); // Output: 15
console.log(multiply(5, -3)); // Output: -15
