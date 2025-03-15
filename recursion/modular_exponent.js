function modExp(a, b, c) {
    // Base case: any number raised to 0 is 1
    if (b === 0) {
        return 1;
    }

    // If b is even
    if (b % 2 === 0) {
        let half = modExp(a, Math.floor(b / 2), c);
        return (half * half) % c;
    }
    // If b is odd
    else {
        return (a * modExp(a, b - 1, c)) % c;
    }
}

// Example usage
console.log(modExp(2, 10, 1000)); // Output: 24 (since 2^10 % 1000 = 1024 % 1000 = 24)
