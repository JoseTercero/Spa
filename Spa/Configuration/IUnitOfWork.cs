﻿using Spa.Services;

namespace Spa.Configuration
{
    public interface IUnitOfWork
    {
        ITreatmentRepository TreatmentRepository { get; }

        ITreatmentTimeRepository TreatmentTimeRepository { get; }

        IUserRepository UserRepository { get; }

        IUserRoleRepository UserRoleRepository { get; }

        IScheduleRepository ScheduleRepository { get; }

        IBookingRepository BookingRepository { get; }

        IBookingStatusRepository BookingStatusRepository { get; }


        void Commit();

        void Dispose();

    }
}
