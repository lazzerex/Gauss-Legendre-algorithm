
I. HOW TO USE THE CODE

1. Clone the project using: git clone

2. Run the Program.cs file in the GaussLegendre folder.

3. There's your Pi(e)!

II. EXPLAINING THE ALGORITHM

The Gauss-Legendre algorithm computes the digits of π. It is notable for being rapidly convergent, with only 25 iterations providing 45 million correct digits of π. However, it has certain downsides (for example, it is computer memory-intensive), therefore for many years, all record-breaking calculations have used other methods (For example, the Chudnovsky algorithm.)

The initial values (user input) will follow the formulae below: 

![image](https://github.com/user-attachments/assets/6420c1d7-93f6-48d9-9280-27109ae851f2)

Repeat the following instructions until the difference of ![image](https://github.com/user-attachments/assets/1e11649a-9a40-4148-bd17-387dc0d23457) and ![image](https://github.com/user-attachments/assets/09dda901-667b-4dac-a677-a8bbc330b3a8) is within the desired accuracy:

![image](https://github.com/user-attachments/assets/dd20b6d5-6790-46b1-9bbe-7fcbeb97e86a)

Finally, π is approximated as:

![image](https://github.com/user-attachments/assets/4e0de34b-4e3a-49cb-9272-94f449fd4e87)

The algorithm exhibits quadratic convergence, which implies that the number of accurate digits doubles for each iteration of the computation.






