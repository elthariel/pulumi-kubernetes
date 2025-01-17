# coding=utf-8
# *** WARNING: this file was generated by pulumigen. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities
from ... import authentication as _authentication

__all__ = [
    'SelfSubjectReviewStatus',
    'SelfSubjectReviewStatusPatch',
]

@pulumi.output_type
class SelfSubjectReviewStatus(dict):
    """
    SelfSubjectReviewStatus is filled by the kube-apiserver and sent back to a user.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "userInfo":
            suggest = "user_info"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in SelfSubjectReviewStatus. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        SelfSubjectReviewStatus.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        SelfSubjectReviewStatus.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 user_info: Optional['_authentication.v1.outputs.UserInfo'] = None):
        """
        SelfSubjectReviewStatus is filled by the kube-apiserver and sent back to a user.
        :param '_authentication.v1.UserInfoArgs' user_info: User attributes of the user making this request.
        """
        if user_info is not None:
            pulumi.set(__self__, "user_info", user_info)

    @property
    @pulumi.getter(name="userInfo")
    def user_info(self) -> Optional['_authentication.v1.outputs.UserInfo']:
        """
        User attributes of the user making this request.
        """
        return pulumi.get(self, "user_info")


@pulumi.output_type
class SelfSubjectReviewStatusPatch(dict):
    """
    SelfSubjectReviewStatus is filled by the kube-apiserver and sent back to a user.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "userInfo":
            suggest = "user_info"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in SelfSubjectReviewStatusPatch. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        SelfSubjectReviewStatusPatch.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        SelfSubjectReviewStatusPatch.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 user_info: Optional['_authentication.v1.outputs.UserInfoPatch'] = None):
        """
        SelfSubjectReviewStatus is filled by the kube-apiserver and sent back to a user.
        :param '_authentication.v1.UserInfoPatchArgs' user_info: User attributes of the user making this request.
        """
        if user_info is not None:
            pulumi.set(__self__, "user_info", user_info)

    @property
    @pulumi.getter(name="userInfo")
    def user_info(self) -> Optional['_authentication.v1.outputs.UserInfoPatch']:
        """
        User attributes of the user making this request.
        """
        return pulumi.get(self, "user_info")


