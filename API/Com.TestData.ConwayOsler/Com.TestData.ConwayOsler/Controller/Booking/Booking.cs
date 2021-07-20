using Com.Core.ConwayOsler.Interface;
using Com.TestData.ConwayOsler.Helper;
using Com.TestData.ConwayOsler.Model.Authorization;
using Com.TestData.ConwayOsler.Model.Booking;
using NUnit.Framework;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Com.TestData.ConwayOsler.Controller.Booking
{
  public class BookingController
  {
    private static Uri _bookingUrl;
    public static string _bookingEndPoint = "booking";
    public static CoreInterface Core = new CoreInterface();

    /// <summary>
    /// Creation of Url Endpoint for Rest Actions.
    /// </summary>
    /// <param name="endPointField">The Url Action Endpoint.</param>
    /// <returns>Returns a Uri Object containing the Rest Endpoint.</returns>
    public async Task<Uri> CreateUriAsync(string endPointField = "")
    {
      return await UriHelper.GetRestfulBookerUriAsync($"{_bookingEndPoint}/{endPointField}").ConfigureAwait(false);
    }

    /// <summary>
    /// Creates a new booking in the API.
    /// </summary>
    /// <typeparam name="T">The expected response type.</typeparam>
    /// <param name="firstName">Firstname for the guest who made the booking.</param>
    /// <param name="lastName">Lastname for the guest who made the booking.</param>
    /// <param name="totalPrice">The total price for the booking.</param>
    /// <param name="depositPaid">Whether the deposit has been paid or not.</param>
    /// <param name="checkIn">Date the guest is checking in.</param>
    /// <param name="checkOut">Date the guest is checking out.</param>
    /// <param name="additionalNeeds">Any other needs the guest has.</param>
    /// <param name="mustValidateResponse">Boolean value indicating whether the rest api response should be validated.</param>
    public async Task<CreateBookingResponse> CreateBookingAsync<T>(
      string firstName = "",
      string lastName = "",
      int? totalPrice = null,
      bool? depositPaid = null,
      string checkIn = "",
      string checkOut = "",
      string additionalNeeds = "",
      bool mustValidateResponse = true)
    {
      Bookings.createBookingRequest = CreateBookingRequest.GetCreateBookingRequest(
        firstName,
        lastName,
        totalPrice,
        depositPaid,
        checkIn,
        checkOut,
        additionalNeeds);

      _bookingUrl = await CreateUriAsync().ConfigureAwait(false);

      Bookings.createBookingResponse = await Core.Api.PostAsync<CreateBookingResponse>(_bookingUrl, Bookings.createBookingRequest, Authorizations.createTokenResponse?.token).ConfigureAwait(false);

      if (mustValidateResponse)
      {
        await Core.Utility.DeepCompare.ObjectCompareAsync(Bookings.createBookingRequest, Bookings.createBookingResponse.booking).ConfigureAwait(false);

        Assert.Multiple(() =>
          {
            //Assert Creation of Booking Id
            Assert.GreaterOrEqual(Bookings.createBookingResponse.bookingid, 0, "BookingId Not Created");

            //Assert Validity of Dates
            Assert.LessOrEqual(Bookings.createBookingResponse.booking.bookingdates.checkin, Bookings.createBookingResponse.booking.bookingdates.checkout, "CheckIn Date Is Later Than CheckOut Date");
          }
        );
      }

      return Bookings.createBookingResponse;
    }

    /// <summary>
    /// Returns a specific booking based upon the booking id provided.
    /// </summary>
    /// <typeparam name="T">The expected response type.</typeparam>
    /// <param name="mustValidateResponse">Boolean value indicating whether the rest api response should be validated.</param>
    public async Task GetBookingAsync<T>(
      string bookingId = "",
      bool mustValidateResponse = true)
    {
      _bookingUrl = await CreateUriAsync(string.IsNullOrEmpty(bookingId) ? Bookings.createBookingResponse.bookingid.ToString() : bookingId).ConfigureAwait(false);

      Bookings.getBookingResponse = await Core.Api.GetAsync<GetBookingResponse>(_bookingUrl, Authorizations.createTokenResponse.token).ConfigureAwait(false);

      if (mustValidateResponse)
      {
        await Core.Utility.DeepCompare.ObjectCompareAsync(Bookings.createBookingRequest, Bookings.getBookingResponse).ConfigureAwait(false);
      }
    }


    /// <summary>
    /// Updates a current booking.
    /// </summary>
    /// <typeparam name="T">The expected response type.</typeparam>
    /// <param name="bookingId">ID for the booking you want to update.</param>
    /// <param name="firstName">Firstname for the guest who made the booking.</param>
    /// <param name="lastName">Lastname for the guest who made the booking.</param>
    /// <param name="totalPrice">The total price for the booking.</param>
    /// <param name="depositPaid">Whether the deposit has been paid or not.</param>
    /// <param name="checkIn">Date the guest is checking in.</param>
    /// <param name="checkOut">Date the guest is checking out.</param>
    /// <param name="additionalNeeds">Any other needs the guest has.</param>
    /// <param name="mustValidateResponse">Boolean value indicating whether the rest api response should be validated.</param>
    public async Task UpdateBookingAsync<T>(
      string bookingId = "",
      string firstName = "",
      string lastName = "",
      int? totalPrice = null,
      bool? depositPaid = null,
      string checkIn = "",
      string checkOut = "",
      string additionalNeeds = "",
      bool mustValidateResponse = true)
    {
      Bookings.updateBookingRequest = UpdateBookingRequest.GetUpdateBookingRequest(
        firstName,
        lastName,
        totalPrice,
        depositPaid,
        checkIn,
        checkOut,
        additionalNeeds);

      _bookingUrl = await CreateUriAsync(string.IsNullOrEmpty(bookingId) ? Bookings.createBookingResponse.bookingid.ToString() : bookingId).ConfigureAwait(false);

      Bookings.updateBookingResponse = await Core.Api.PutAsync<T>(_bookingUrl, Bookings.updateBookingRequest, Authorizations.createTokenResponse.token).ConfigureAwait(false);

      if (mustValidateResponse)
      {
        await Core.Utility.DeepCompare.ObjectCompareAsync(Bookings.updateBookingRequest, Bookings.updateBookingResponse);
      }
    }

    /// <summary>
    /// Cancellation of the customers reservation and deletion thereof.
    /// </summary>
    /// <typeparam name="T">The expected response type.</typeparam>
    /// <param name="bookingId">ID for the booking you want to update.</param>
    /// <param name="mustValidateResponse">Boolean value indicating whether the rest api response should be validated.</param>
    public async Task DeleteBookingAsync<T>(
      string bookingId = "",
      bool mustValidateResponse = true)
    {
      _bookingUrl = await CreateUriAsync(string.IsNullOrEmpty(bookingId) ? Bookings.createBookingResponse.bookingid.ToString() : bookingId).ConfigureAwait(false);

      Bookings.deleteBookingResponse = await Core.Api.DeleteAsync<T>(_bookingUrl, Authorizations.createTokenResponse.token).ConfigureAwait(false);

      if (mustValidateResponse)
      {
        Assert.AreEqual(HttpStatusCode.Created.ToString(), Bookings.deleteBookingResponse);
      }
    }
  }
}
