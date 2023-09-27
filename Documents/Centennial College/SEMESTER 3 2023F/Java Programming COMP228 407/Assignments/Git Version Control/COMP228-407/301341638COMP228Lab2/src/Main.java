import java.security.SecureRandom;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        //Get user's input
        String userInput = getInputfromUser();
        //Get computer's output
        String computerInput = computerValue();
        //Pass value to playGame method to play the game
        playGame(userInput, computerInput);
    }

    public static String getInputfromUser(){
        //Create scanner to obtain input from the command window
        Scanner input = new Scanner(System.in);
        boolean isValidInput = false;
        String inputString = "";

        //Loop to validate input
        while(!isValidInput){
            //Prompt User for Input
            System.out.print("Welcome to the game ROCK, PAPER, SCISSOR!\n" +
                    "Enter a valid input:\n" +
                    "R for Rock\n" +
                    "P for Paper\n" +
                    "S for Scissor\n ");
            //Read the string entered by the user
            //Convert it to uppercase
            inputString = input.nextLine().toUpperCase();
            if(inputString.equals("R")||
                    inputString.equals("P")||
                    inputString.equals("S")){
                isValidInput = true;
                System.out.printf("You chose %s\n",inputString);
            } else {
                System.out.print("Invalid input. Please enter again: ");
            }
        }
        input.close();
        return inputString;
    }

    public static String computerValue(){
        //Create an array
        String[] gameOptions = {"R", "P", "S"};
        //Random number generator to get index for gameOptions
        final SecureRandom randomNumber = new SecureRandom();
        int computerRandomChoice = randomNumber.nextInt(2);
        //Assign random number to gameOptions index
        String computerValue = gameOptions[computerRandomChoice];
        System.out.printf("Computer chose %s\n",computerValue);
        return computerValue;
    }
    //Game status enum
    enum Status {WON, LOST, DRAW};

    public static void playGame(String userInput, String computerInput ){
        Status gameStatus;
        String inputUser = userInput;
        String inputComputer = computerInput;
        //What happens when it's a draw
        if(inputUser.equals(inputComputer)){
            gameStatus = Status.DRAW;
            System.out.printf("It's a %s\n",gameStatus);
            getInputfromUser();
        } else if (
                //Win conditions
                (inputUser.equals("R") && inputComputer.equals("S")) ||
                        (inputUser.equals("P") && inputComputer.equals("R")) ||
                        (inputUser.equals("S") && inputComputer.equals("P"))
        ){
            //What happens if use win the game
            gameStatus = Status.WON;
            System.out.printf("You %s. Congratulations!\n",gameStatus);
        } else {
            //What happens when user lose the game
            gameStatus = Status.LOST;
            System.out.printf("You %s. Better luck next time!\n",gameStatus);
        }
    }
}

