using System;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;



            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */
            int raccoonsInTheWoods = 3;
            int raccoonsThatLeftForDinner = 2;
            int raccoonsRemaining = raccoonsInTheWoods - raccoonsThatLeftForDinner;
            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */
            int numberOfFlowers = 5;
            int numberOfBees = 3;
            int numberOfExtraBees = numberOfFlowers - numberOfBees;
            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */
            int initialNumberOfPigeons = 1;
            int pigeonsThatCameToEat = 1;
            int totalPigeons = initialNumberOfPigeons + pigeonsThatCameToEat; 
            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */
            int initialNumberOfOwls = 3;
            int owlsThatJoined = 2;
            int totalOwls = initialNumberOfOwls + owlsThatJoined;
            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */
            int beaversWorking = 2;
            int beaversThatLeftToSwim = 1;
            int beaversRemaining = beaversWorking - beaversThatLeftToSwim;
            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */
            int initialNumberOfToucans = 2;
            int toucansThatJoined = 1;
            int totalNumberOfToucans = initialNumberOfToucans + toucansThatJoined;
            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */
            int numberOfSquirrels = 4;
            int numberOfNuts = 2;
            int numberOfSquirrelsWithoutNuts = numberOfSquirrels - numberOfNuts;
            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */
            double quarter = 0.25;
            double dime = 0.10;
            double nickel = 0.05;
            double moneyFound = quarter + dime + 2 * nickel;
            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */
            int muffinsBrierClass = 18;
            int muffinsMacAdamsClass = 20;
            int muffinsFlanneryClass = 17;
            int muffinsFirstGrade = muffinsBrierClass + muffinsMacAdamsClass + muffinsFlanneryClass;
            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            double costYoyo = 0.24;
            double costWhistle = 0.14;
            double totalSpentOnToys = costYoyo + costWhistle;
            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows.How many marshmallows did she use
            altogether?
            */
            int largeMarshmallows = 8;
            int miniMarshmallows = 10;
            int totalNumberOfMarshmallows = largeMarshmallows + miniMarshmallows;
            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int inchesSnowHome = 29;
            int inchesSnowSchool = 17;
            int inchesDifference = inchesSnowHome - inchesSnowSchool;
            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            int startingMoney = 10;
            int costOfToyTruck = 3;
            int costOfPencil = 2;
            int remainingMoney = startingMoney - costOfToyTruck - costOfPencil;
            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int marblesInCollection = 16;
            int marblesLost = 7;
            int marblesRemaining = marblesInCollection - marblesLost;
            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int numShellsInCollection = 19;
            int numDesiredShells = 25;
            int numShellsNeeded = numDesiredShells - numShellsInCollection;
            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int totalNumberOfBalloons = 17;
            int numberOfRedBalloons = 8;
            int numberOfGreenBalloons = totalNumberOfBalloons - numberOfRedBalloons;
            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int booksInitiallyOnShelf = 38;
            int booksAdded = 10;
            int booksCurrentlyOnShelf = booksInitiallyOnShelf + booksAdded;
            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int legsOnOneBee = 6;
            int legsOnEightBees = legsOnBee * 8;
            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            double costOfOneCone = 0.99;
            double costOfTwoCones = costOfOneCone * 2;

            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int rocksRequired = 125;
            int rocksOwned = 64;
            int rocksNeeded = rocksRequired - rocksOwned;
            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int marblesOwned = 38;
            int marblesLost = 15;
            int marblesRemaining = marblesOwned - marblesLost;
            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int totalMiles = 78;
            int milesWhenStopped = 
            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time did she spend shoveling snow?
            */
             
            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            int numberOfHotDogs = 6;
            double costPerHotDog = 0.50;
            double totalCost = costPerHotDog * numberOfHotDogs;

            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            double totalMoney = 0.50;
            double costOfPencil = 0.07;
            double numOfPencilsCanBuy = totalMoney / costOfPencil;
            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int totalNumberOfButterflies = 33;
            int numberOfOrangeButterflies = 20;
            int numberOfRedButterflies = totalNumberOfButterflies - numberOfRedButterflies;
            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            double moneyPaidToClerk = 1.00;
            double costOfCandy = 0.54;
            double returnChange = moneyPaidToClerk - costOfCandy;

            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int numberOfTreesCurrent = 13;
            int numberOfTreesToBePlanted = 12;
            int newNumberOfTrees = numberOfTreesCurrent + numberOfTreesToBePlanted;
            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int hoursPerDay = 24;
            int daysUntilVisitingGrandma = 2;
            int hoursUntilVisitingGrandma = hoursPerDay * daysUntilVisitingGrandma;
            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int numberOfCousins = 4;
            int piecesOfGumPerCousin = 5;
            int amountOfGumNeeded = numberOfCousins * piecesOfGumPerCousin;
            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            double startingMoney = 3.00;
            double candyBarCost = 1.00;
            double leftoverMoney = startingMoney - candyBarCost;
            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int numberOfBoats = 5;
            int numberOfPeoplePerBoat = 3;
            int totalNumberOfPeople = numberOfBoats * numberOfPeoplePerBoat;
            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int numberOfLegosStarting = 380;
            int numberOfLegosLost = 57;
            int numberOfLegosRemaining = numberOfLegosStarting - numberOfLegosLost;
            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int initialNumberOfMuffins = 35;
            int goalNumberOfMuffins = 83;
            int numberOfMuffinsNeeded = goalNumberOfMuffins - initialNumberOfMuffins;
            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int numberOfCrayonsWilly = 1400;
            int numberOfCrayonsLucy = 290;
            int numberOfCrayonsDifference = numberOfCrayonsWilly - numberOfCrayonsLucy;
            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int stickersPerPage = 10;
            int numberOfPages = 22;
            int numberOfStickers = stickersPerPage * numberOfPages;

            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            int numOfCupcakes = 96;
            int numOfChildren = 8;
            int cupcakesPerChild = numOfCupcakes / numOfChildren;
            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */
            int numOfCookies = 47;
            int cookiesPerJar = 6;
            int cookiesNotInJar = 47 % 6;
            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */
            int numberOfCroissants = 59;
            int numverOfNeighbors = 8;
            int numberLeftoverAfterDividing = numberOfCroissants % numberOfNeighbors;
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int oatmealCookies = 276;
            int cookiesPerTray = 12;
            int numberOfTraysNeeded = oatmealCookies / cookiesPerTray; 
            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int numberOfPretzels = 480;
            int numberOfPretzelsPerServing = 12;
            int numberOfServings = numberOfPretzels / numberOfPretzelsPerServing;

            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int numberOfCupcakesBaked = 53;
            int numberOfCupcakesLeftBehind = 2;
            int numberOfCupcakesPerBox = 3;
            int numberOfBoxesGivenAway = (numberOfCupcakesBaked - numberOfCupcakesLeftBehind) / numberOfCupcakesPerBox;

            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int numberOfCarrots = 74;
            int sharePerPerson = 12;
            int carrotsRemaining = numberOfCarrots % sharePerPerson;
            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int numberOfBears = 98;
            int bearCapacityPerShelf = 7;
            int numberOfShelvesFilled = numberOfBears / bearCapacityPerShelf;
            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int numberOfPictures = 480;
            int picturesPerAlbum = 20;
            int numberOfAlbumsRequired = numberOfPictures / picturesPerAlbum;
            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int numberOfTradingCards = 94;
            int maxTradingCardsPerBox = 8;
            int numberOfFullBoxes = numberOfTradingCards / maxTradingCardsPerBox;
            int numberOfCardsRemaining = numberOfTradingCards % maxTradingCardsPerBox;

            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int numberOfBooks = 210;
            int numberOfBookshelves = 10;
            int numberOfBooksPerShelf = numberOfBooks / numberOfBookshelves; 
            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            int numberOfCroissants = 17;
            int numberOfGuests = 7;
            int croissantsPerGuest = numberOfCroissants / numberOfGuests;
            /*
                CHALLENGE PROBLEMS
            */

            /*
            Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painter working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            Challenge: How many days will it take the pair to paint 623 rooms assuming they work 8 hours a day?.
            */

            /*
            Create and assign variables to hold your first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold your full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period.
            Example: "Hopper, Grace B."
            */

            /*
            The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip has been completed?
            Hint: The percent completed is the miles already travelled divided by the total miles.
            Challenge: Display as an integer value between 0 and 100 using casts.
            */

        }
    }
}
