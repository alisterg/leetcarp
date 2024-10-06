namespace LeetCarp.Easy;

public class _605_CanPlaceFlowers
{

    /// <summary>
    /// You have a long flowerbed in which some of the plots are planted, and
    /// some are not. However, flowers cannot be planted in adjacent plots.
    /// <br />
    /// Given an integer array flowerbed containing 0's and 1's, where 0 means empty
    /// and 1 means not empty, and an integer n, return true if n new flowers can be
    /// planted in the flowerbed without violating the no-adjacent-flowers rule, and
    /// false otherwise.
    /// </summary>
    public static bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        var numPlanted = 0;
        var didPlantPrevious = false;

        for (int i = 0; i < flowerbed.Length; i++)
        {
            var prev = didPlantPrevious || (i > 0 && flowerbed[i - 1] == 1) ? 1 : 0;
            var next = i == flowerbed.Length - 1 ? 0 : flowerbed[i + 1];
            didPlantPrevious = false;

            var shouldPlant = flowerbed[i] == 0 && (prev == 0 || didPlantPrevious) && next == 0;

            if (shouldPlant)
            {
                didPlantPrevious = true;
                numPlanted++;
            }
        }

        return numPlanted >= n;
    }

}