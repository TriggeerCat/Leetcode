using System;
using System.Collections.Generic;
using System.Linq;

namespace _1845.SeatReservationManager
{
    public class SeatManager
    {
        private int _lastReservedSeat = 0;
        private List<int> _availableSeats = new List<int>();
        
        public SeatManager(int n) 
        {
            
        }
    
        public int Reserve() 
        {
            if (_availableSeats.Count == 0)
            {
                _lastReservedSeat++;
                return _lastReservedSeat;
            }
            int seatNumber = _availableSeats.Min();
            _availableSeats.Remove(seatNumber);
            return seatNumber;
        }
    
        public void Unreserve(int seatNumber) 
        {
            _availableSeats.Add(seatNumber);
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            SeatManager seatManager = new SeatManager(5);
            Console.WriteLine(seatManager.Reserve());
            Console.WriteLine(seatManager.Reserve());
            seatManager.Unreserve(2);
            Console.WriteLine(seatManager.Reserve());
            Console.WriteLine(seatManager.Reserve());
            Console.WriteLine(seatManager.Reserve());
            Console.WriteLine(seatManager.Reserve());
            seatManager.Unreserve(5);
        }
    }
}