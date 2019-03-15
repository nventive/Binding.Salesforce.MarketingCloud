using System;
using ObjCRuntime;

namespace MarketingCloud
{
    [Native]
    public enum configureError : uint
    {
        firstConfigureErrorIndex = 0,
        configureNoError = firstConfigureErrorIndex,
        configureInvalidAppIDError,
        configureInvalidAccessTokenError,
        configureUnableToReadRandomError,
        configureDatabaseAccessError,
        configureUnableToKeyDatabaseError,
        configureCCKeyDerivationPBKDFError,
        configureCCSymmetricKeyWrapError,
        configureCCSymmetricKeyUnwrapError,
        configureKeyChainError,
        configureUnableToReadCertificateError,
        configureRunOnceSimultaneouslyError,
        configureRunOnceError,
        configureInvalidLocationAndProximityError,
        configureSimulatorBlobError,
        configureKeyChainInvalidError,
        configureIncorrectConfigurationCallingSequenceError,
        configureMissingConfigurationFileError,
        configureInvalidConfigurationFileError,
        configureInvalidConfigurationIndexError,
        configureFailedFrameworkCreationError,
        lastConfigureErrorIndex = configureFailedFrameworkCreationError
    }
}