using System;
using System.Collections.Generic;
using System.Text;

namespace Rental.Model
{
    public class Car
    {
        public int CarId { get; set; }

        /// <summary>
        /// Gets or sets the registration number.
        /// </summary>
        /// <value>
        /// The registration number.
        /// </value>
        public string RegistrationNumber { get; set; }

        // Is car available? True = available, False = unavailable
        /// <summary>
        /// Gets or sets a value indicating whether [available status].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [available status]; otherwise, <c>false</c>.
        /// </value>
        public bool AvailableStatus { get; set; }

        // Which company produced car
        /// <summary>
        /// Gets or sets the make.
        /// </summary>
        /// <value>
        /// The make.
        /// </value>
        public string Make { get; set; }

        // Which model of car it is
        /// <summary>
        /// Gets or sets the car model.
        /// </summary>
        /// <value>
        /// The car model.
        /// </value>
        public string CarModel { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public double Price { get; set; }

        /// <summary>
        /// Gets or sets the number of doors.
        /// </summary>
        /// <value>
        /// The number of doors.
        /// </value>
        public int NumberOfDoors { get; set; }

        /// <summary>
        /// Gets or sets the img URL.
        /// </summary>
        /// <value>
        /// The img URL.
        /// </value>
        public string ImgUrl { get; set; }

        public string FullCar => $"{Make} {CarModel}";

        public bool CarValidationCheck { get => !string.IsNullOrEmpty(Make) && !string.IsNullOrEmpty(CarModel); }
    }
}
